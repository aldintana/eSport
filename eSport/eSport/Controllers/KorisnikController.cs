using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSport.Model;
using eSport.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSport.Controllers
{
    public class KorisnikController : BaseCRUDController<Model.Korisnik, Model.BaseSearchRequest, Model.KorisnikInsertRequest, Model.KorisnikInsertRequest>
    {
        public KorisnikController(IKorisnikService service) :base(service)
        {
        }

        [AllowAnonymous]
        public override Korisnik Insert([FromBody] KorisnikInsertRequest request)
        {
            return base.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        public override Korisnik Update(int id, [FromBody] KorisnikInsertRequest request)
        {
            return base.Update(id, request);
        }
    }
}
