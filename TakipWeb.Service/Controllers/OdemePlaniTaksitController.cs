using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TakipWeb.Entities;
using TakipWeb.Business.Operations;


namespace TakipWeb.Service.Controllers
{
    public class OdemePlaniTaksitController : ApiController
    {
        public List<OdemePlaniTaksitEntity> GetOdemePlaniTaksitListe()
        {
            var list = OdemePlaniTaksitOperations.Select(new OdemePlaniTaksitEntity());

            return list;


        }

        [Route("api/OdemePlaniTaksit/InsertOdemePlaniTaksit")]
        [HttpPost]
        public void InsertOdemePlaniTaksit(OdemePlaniTaksitEntity request)
        {

            OdemePlaniTaksitOperations.InsertOdemePlaniTaksit(request);


        }
        [HttpPost]
        public void UpdateOdemePlaniTaksit(OdemePlaniTaksitEntity request)
        {

            OdemePlaniTaksitOperations.UpdateOdemePlaniTaksit(request);



        }


    }
}