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
    public class OdemePlaniController : ApiController
    {


        [Route("api/OdemePlani/GetOdemePlaniListe")]
        [HttpPost]
        public List<OdemePlaniEntity> GetOdemePlaniListe(OdemePlaniEntity request)
        {
            var list = OdemePlaniOperations.SelectOdemePlani(request);

            return list;
        }

        [Route("api/OdemePlani/InsertOdemePlani")]
        [HttpPost]
        public OdemePlaniEntity InsertOdemePlani(OdemePlaniEntity request)
        {
            int id = OdemePlaniOperations.InsertOdemePlani(request);
            request.Id = id;
            return request;
        }

        [Route("api/OdemePlani/UpdateOdemePlani")]
        [HttpPost]
        public void UpdateOdemePlani(OdemePlaniEntity request)
        {

            OdemePlaniOperations.UpdateOdemePlani(request);

        }
    }
}