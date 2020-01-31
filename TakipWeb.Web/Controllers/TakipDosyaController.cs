using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakipWeb.Business.Operations;
using TakipWeb.Web.Models;
using System.Web.UI;
using TakipWeb.Web.Controllers;
using TakipWeb.Service.Core;
using TakipWeb.Entities;

namespace TakipWeb.Web.Controllers
{

    //takipdb entities takip.web.entities kalsörünün içindeki takipdosya entity içinde
    public class TakipDosyaController : Controller
    {
        // GET: TakipDosya
        public ActionResult Index()
        {
            var serviceList = Operations.GetResponse<List<TakipDosyaEntity>>("http://localhost:27863/api/takipdosya/GetTakipDosyaListe");
            return View(serviceList);
        }

        public ActionResult Details(int PMusteriNo)
        {

            ViewBag.MusteriNo = PMusteriNo;

            return View();

        }

    }


    /*  public static List<TakipDosyaOrnek> GetList()
      {


        /*  var returnmodel = new List<TakipDosyaOrnek>();

          var firstVar = new TakipDosyaOrnek
          {
              Id = 456789,
              SubeKodu = "B0005",
              MusteriNo = "M566846558",
              BirimKodu = "S566644",
              IlKodu = 35,
              IlceKodu = 35020,
              Borc = 250.00M,
              TahsilTutari = 170.00M




          };
          var secondVar = new TakipDosyaOrnek
          {
              Id = 456789,
              SubeKodu = "B0005",
              MusteriNo = "M566846558",
              BirimKodu = "S566644",
              IlKodu = 35,
              IlceKodu = 35020,
              Borc = 250.00M,
              TahsilTutari = 170.00M



          };
          var thirdVar = new TakipDosyaOrnek
          {

              Id = 42669,
              SubeKodu = "B0005",
              MusteriNo = "M99562258",
              BirimKodu = "S115644",
              IlKodu = 65,
              IlceKodu = 65020,
              Borc = 250.00m,
              TahsilTutari = 170.00m


          };

          var fourthVar = new TakipDosyaOrnek
          {

              Id = 95289,
              SubeKodu = "B0055",
              MusteriNo = "M561455258",
              BirimKodu = "S511144",
              IlKodu = 29,
              IlceKodu = 29020,
              Borc = 550.00m,
              TahsilTutari = 470.00m





          };

          for (var i = 0; i < 10; i++)
          {

              returnmodel.Add(firstVar);
              returnmodel.Add(secondVar);
              returnmodel.Add(thirdVar);
              returnmodel.Add(fourthVar);


          }
          return returnmodel;

      }*/
}
