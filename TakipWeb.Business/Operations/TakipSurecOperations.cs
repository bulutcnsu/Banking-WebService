using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakipWeb.Business;
using TakipWeb.Entities;
using TakipWeb.Model;

namespace TakipWeb.Business.Operations
{
    public class TakipSurecOperations
    {
        public static void DeleteSurec(int id)
        {
            using (var db = new TakipDbEntities())
            {
                var td = db.TakipSurec.FirstOrDefault(x => x.Id == id);
                db.TakipSurec.Attach(td);
                db.TakipSurec.Remove(td);
                db.SaveChanges();
            }
        }
        public static void UpdateTakipSurec(TakipSurecEntity td)
        {
            using (var db = new TakipDbEntities())
            {
                TakipSurec ts = new TakipSurec();
              //  var ts = db.TakipSurec.FirstOrDefault(x => x.Id == td.Id);
                ts.MusteriNo = td.MusteriNo;
                ts.SurecKodu = td.SurecKodu;
                ts.DosyaId = td.DosyaId;

                db.TakipSurec.Attach(ts);
                db.TakipSurec.Add(ts);
                db.SaveChanges();

            }
        }

        public static List<TakipSurecEntity> Select(TakipSurecEntity model)
        {
            using (var db = new TakipDbEntities())
            {

                var dblist = db.TakipSurec.ToList();
                var entityList = new List<TakipSurecEntity>();

                foreach (var item in dblist)
                {
                    var temp = new TakipSurecEntity()
                    {
                        Id = item.Id,
                        MusteriNo=item.MusteriNo,
                        DosyaId=item.DosyaId,
                        SurecKodu=item.SurecKodu
                        
                    };

                    entityList.Add(temp);
                }

                return entityList;  
        }

        }

        public static void InsertTakipSurec(TakipSurecEntity td)
        {

            using (var db = new TakipDbEntities())
            {
                TakipSurec ts = new TakipSurec();
                ts.MusteriNo = td.MusteriNo;
                ts.SurecKodu = td.SurecKodu;
                ts.DosyaId = td.DosyaId;

                db.TakipSurec.Attach(ts);
                db.TakipSurec.Add(ts);
                db.SaveChanges();

            }
        }


    }
}

