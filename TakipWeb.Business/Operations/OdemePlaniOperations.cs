using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakipWeb.Entities;
using TakipWeb.Model;

namespace TakipWeb.Business.Operations
{
   public  class OdemePlaniOperations
    {

        public static void DeleteOdemePlani(int id)
        {
            using (var db = new TakipDbEntities())
            {
                OdemePlani td = db.OdemePlani.FirstOrDefault(x => x.Id == id);
                db.OdemePlani.Attach(td);
                db.OdemePlani.Remove(td);
                db.SaveChanges();

            }
        }

        public static void UpdateOdemePlani(OdemePlaniEntity td)
        {
            using (var db = new TakipDbEntities())
            {
                OdemePlani veri = new OdemePlani();
                veri = db.OdemePlani.FirstOrDefault(x => x.Id == td.Id);

                veri.MusteriNo = td.MusteriNo;
                veri.DosyaId = td.DosyaId;
                veri.DurumKodu = td.DurumKodu;

                db.OdemePlani.Attach(veri);
                db.OdemePlani.Add(veri);
                db.SaveChanges();

            }
        }
        public static int InsertOdemePlani(OdemePlaniEntity obj)
        {
            using (var od = new TakipDbEntities())
            {
                

                OdemePlani veri = new OdemePlani();
                // veri = od.OdemePlani.FirstOrDefault(x => x.Id == obj.Id);

                veri.MusteriNo = obj.MusteriNo;
                veri.DosyaId = obj.DosyaId;
                veri.DurumKodu = obj.DurumKodu;

                od.OdemePlani.Attach(veri);
                od.OdemePlani.Add(veri);
                od.SaveChanges();

                return veri.Id;
            }

        }

        public static List<OdemePlaniEntity> SelectOdemePlani(OdemePlaniEntity obj)

        {
            using (var db = new TakipDbEntities())

            {

                var dblist = db.OdemePlani.ToList();
                var entityList = new List<OdemePlaniEntity>();

                 if (!string.IsNullOrEmpty(obj.MusteriNo))
                  {
                      var list = db.OdemePlani.Where(x => x.MusteriNo == obj.MusteriNo).ToList();
                      //return list;
                  }
                  return new List<OdemePlaniEntity>();

               /* foreach (var item in dblist)
                {
                    var temp = new OdemePlaniEntity()
                    {

                        Id = item.Id,
                        MusteriNo = item.MusteriNo,
                        DurumKodu = item.DurumKodu,
                        DosyaId = item.DosyaId

                    };

                    entityList.Add(temp);
                }*/

                return entityList;
            }


        }
    }
}

    


