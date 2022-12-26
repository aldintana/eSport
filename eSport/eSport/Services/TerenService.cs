using System;
using AutoMapper;
using System.Linq;
using eSport.Model;
using Microsoft.ML;
using eSport.Database;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eSport.Services
{
    public class TerenService : BaseCRUDService<Model.Teren, TerenSearchRequest, Database.Teren, TerenInsertRequest, TerenInsertRequest>, ITerenService
    {
        public TerenService(DatabaseContext context, IMapper mapper):base(context, mapper)
        {

        }
        public override IEnumerable<Model.Teren> Get(TerenSearchRequest search = null)
        {
            var entity = _context.Set<Database.Teren>().AsQueryable();
            
            entity = entity.Where(e => e.IsDeleted == search.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search.TekstPretraga))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.TekstPretraga));
            }

            if (search.SportId.HasValue)
            {
                entity = entity.Where(x => x.SportId == search.SportId);
            }

            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }
            if (search.KorisnikId.HasValue)
                return TerenRecommenderSystem(entity, search.KorisnikId.GetValueOrDefault());

            var list = entity.ToList();

            return _mapper.Map<List<Model.Teren>>(list);
        }

        static object isLocked = new object();
        static MLContext mlContext = null;
        static ITransformer model = null;
        public IEnumerable<Model.Teren> TerenRecommenderSystem(IQueryable<Database.Teren> entity, int korisnikId)
        {
            lock (isLocked)
            {
                if (mlContext == null)
                {
                    mlContext = new MLContext();

                    var tmpData = _context.Termins.Include(x => x.Teren).ThenInclude(x => x.Sport).ToList();

                    var data = new List<TerenEntry>();

                    var sportTereni = tmpData.GroupBy(x => (x.Teren.SportId)).Select(
                       x => new
                       {
                           SportId = x.Key,
                           TerenCount = x.Count()
                       }).OrderByDescending(x => x.TerenCount).ToList();

                    foreach (var x in tmpData)
                    {
                        if (x.Teren != null && x.Teren.Sport != null)
                        {
                            var sportCount = sportTereni.FirstOrDefault(s => s.SportId == x.Teren.SportId);
                            data.Add(new TerenEntry
                            {
                                KorisnikId = (uint)x.KorisnikId.GetValueOrDefault(),
                                TerenId = (uint)x.TerenId,
                                SportCount = sportCount.TerenCount
                            });
                        }
                    }

                    var trainData = mlContext.Data.LoadFromEnumerable(data);
                    var trainTestSplit = mlContext.Data.TrainTestSplit(trainData, testFraction: 0.2);
                    var trainingData = trainTestSplit.TrainSet;
                    var testData = trainTestSplit.TestSet;

                    var options = new MatrixFactorizationTrainer.Options
                    {
                        MatrixColumnIndexColumnName = nameof(TerenEntry.KorisnikId),
                        MatrixRowIndexColumnName = nameof(TerenEntry.TerenId),
                        LabelColumnName = "SportCount",
                        LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass,
                        Alpha = 0.01,
                        Lambda = 0.025
                    };

                    var trainer = mlContext.Recommendation().Trainers.MatrixFactorization(options);

                    model = trainer.Fit(trainingData);
                }
            }        

            var predictionResult = new List<Tuple<Database.Teren, float>>();

            foreach (var item in entity)
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<TerenEntry, TerenPrediction>(model);
                var prediction = predictionEngine.Predict(new TerenEntry()
                {
                    KorisnikId = (uint)korisnikId,
                    TerenId = (uint)item.Id
                });
                predictionResult.Add(new Tuple<Database.Teren, float>(item, prediction.Score));                      
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
                .Select(x => x.Item1).ToList();

            return _mapper.Map<List<Model.Teren>>(finalResult);
        }

        public class TerenEntry
        {
            [KeyType(count: 10)]
            public uint KorisnikId { get; set; }
            [KeyType(count: 10)]
            public uint TerenId { get; set; }
            public float SportCount { get; set; }
        }

        public class TerenPrediction
        {
            [KeyType(count: 10)]
            public uint TerenId { get; set; }
            public float Score { get; set; }
            public float Label { get; set; }
        }
    }
}
