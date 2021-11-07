using eSport.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSport.Services
{
    public interface ISportService
    {
        List<Model.Sport> Get();
    }
}
