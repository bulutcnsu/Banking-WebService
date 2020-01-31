using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TakipWeb.Business.Operations;
using TakipWeb.Entities;

namespace TakipWeb.Service.Controllers
{
    public class TakipDosyaController : ApiController
    {
       

        public List<TakipDosyaEntity> GetTakipDosyaListe()
        {
            var list = TakipDosyaOperations.Select(new TakipDosyaEntity());

            return list;

        }

        [HttpPost]
        public void InsertTakipDosya(TakipDosyaEntity request)
        {
            TakipDosyaOperations.InsertTakipDosya(request);

        }
        [HttpPost]

        public void UpdateTakipDosya(TakipDosyaEntity request)
        {
            TakipDosyaOperations.UpdateTakipDosya(request);

        }


    }
}
