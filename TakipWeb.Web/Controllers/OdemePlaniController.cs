using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakipWeb.Business.Operations;
using System.Web.UI;
using TakipWeb.Web.Controllers;
using TakipWeb.Service.Core;
using TakipWeb.Entities;
using TakipWeb.Model;
using ConsoleApplication1;
using System.Data;


namespace TakipWeb.Web.Controllers
{
    public class OdemePlaniController : Controller
    {
        public string TakipDosyaList { get; private set; }

        // GET: OdemePlani

        public ActionResult Index()
        {
            var serviceList = Operations.GetResponse<List<TakipDosyaEntity>>("http://localhost:27863/api/takipdosya/GetTakipDosyaListe");

            var odemePlaniList = Operations.GetResponse<List<OdemePlaniEntity>>("http://localhost:27863/api/odemeplani/GetOdemePlaniListe");

            return View(serviceList);

        }
        public ActionResult OdemePlaniYap(int takipDosyaId, bool odemePlaniVar, string musteriNo,
            decimal borc, decimal tahsilTutari)
        {

            if (odemePlaniVar)
            {

                var temp =new  OdemePlaniEntity();

           
                      


                var result = Operations.PostJson("http://localhost:27863/api/odemeplanitaksit/InsertOdemePlaniTaksit", temp);

                return View();
            }
            TakipDosyaEntity td = new TakipDosyaEntity()
            {
                Id = takipDosyaId,
                MusteriNo = musteriNo,
                Borc = borc,
                TahsilTutari = tahsilTutari
            };
            return View(td);
        }

        public ActionResult OdemePlaniEkle(FormCollection form)
        {
            String musterino = form["musteriNo"].ToString();
            int dosyaid = Convert.ToInt32(form["DosyaId"].ToString());
            int taksitno = Convert.ToInt32(form["TaksitNo"].ToString());
            decimal borc = Convert.ToDecimal(form["borc"].ToString());
            decimal tahsilTutari = Convert.ToDecimal(form["TahsilTutari"].ToString());

            var odemePlaniEntity = new OdemePlaniEntity()
            {
                MusteriNo = musterino,
                DosyaId = dosyaid,
                DurumKodu = true,
            };
            //taksit olusturma ekranı yap
            var odemePlaniTaksitListe = new List<OdemePlaniTaksitEntity>();
            var result = Operations.PostJson("http://localhost:27863/api/odemeplani/InsertOdemePlani", odemePlaniEntity);

            for (int i = 0; i < taksitno; i++)
            {
                var tempOdemePlaniTaksit = new OdemePlaniTaksitEntity();

                tempOdemePlaniTaksit.TaksitNo = i + 1;
                tempOdemePlaniTaksit.TaksitTarihi = DateTime.Now.AddDays(i * 30); // i?
                tempOdemePlaniTaksit.TaksitTutari = (borc - tahsilTutari) / taksitno;
                tempOdemePlaniTaksit.OdemePlaniId = result.Id;

                //odemePlaniTaksitListe.Add(tempOdemePlaniTaksit);

                Operations.PostJson("http://localhost:27863/api/odemeplanitaksit/InsertOdemePlaniTaksit", tempOdemePlaniTaksit);

            }

            return RedirectToAction("Index", "TakipDosya", new { area = "" });
        }
    }
}
