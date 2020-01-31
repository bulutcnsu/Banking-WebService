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
    public class TakipSurecController : ApiController
    {
       
        
        public List<TakipSurecEntity> GetTakipSurecListe()
        {
            var list = TakipSurecOperations.Select(new TakipSurecEntity());

            return list;

        }


        [HttpPost]
        public void InsertTakipSurec(TakipSurecEntity request)
        {
            TakipSurecOperations.InsertTakipSurec(request);

        }

        [HttpPost]
        public void UpdateTakipSurec(TakipSurecEntity request)
        {
            TakipSurecOperations.UpdateTakipSurec(request);


        }

    }
}
