using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakipWeb.Entities;
using TakipWeb.Model;

namespace TakipWeb.Business.Operations
{
   public class OdemePlaniTaksitOperations
    {

        public static void Delete(int id)
        {
            using (var db = new TakipDbEntities())
            {
                var del = db.OdemePlaniTaksit.FirstOrDefault(x => x.Id == id);
                db.OdemePlaniTaksit.Remove(del);
                db.SaveChanges();
            }
        }
        public static void UpdateOdemePlaniTaksit(OdemePlaniTaksitEntity veri)
        {
            using (var db = new TakipDbEntities())
            {

                OdemePlaniTaksit od = new OdemePlaniTaksit();

                od.OdemePlaniId = veri.OdemePlaniId;
                od.TaksitNo = veri.TaksitNo;
                od.TaksitTarihi = veri.TaksitTarihi;
                od.TaksitTutari = veri.TaksitTutari;

                db.OdemePlaniTaksit.Attach(od);
                db.OdemePlaniTaksit.Add(od);
                db.SaveChanges();
            }
        }

     

        public static List<OdemePlaniTaksitEntity> Select(OdemePlaniTaksitEntity model)

        {
            using (var db = new TakipDbEntities())
            {
              
                  //  OdemePlaniTaksitOperations od = new OdemePlaniTaksitOperations();
                    var dblist = db.OdemePlaniTaksit.ToList();
                    var entityList = new List<OdemePlaniTaksitEntity>();
             

                foreach (var item in dblist)
                {
                    var temp = new OdemePlaniTaksitEntity()
                    {
                        Id = item.Id,
                        OdemePlaniId=item.OdemePlaniId,
                        TaksitNo=item.TaksitNo,
                        TaksitTarihi=item.TaksitTarihi,
                        TaksitTutari=item.TaksitTutari
                        
                    };

                    entityList.Add(temp);
                }

                return entityList;
            }
      
            }
       

        public static void InsertOdemePlaniTaksit(OdemePlaniTaksitEntity od)
        {
            using (var db = new TakipDbEntities())
            {

                OdemePlaniTaksit pd = new OdemePlaniTaksit();
               // pd = db.OdemePlaniTaksit.FirstOrDefault(x => x.Id == od.Id);

                pd.OdemePlaniId = od.OdemePlaniId;
                pd.TaksitNo = od.TaksitNo;
                pd.TaksitTarihi = od.TaksitTarihi;
                pd.TaksitTutari = od.TaksitTutari;

                db.OdemePlaniTaksit.Attach(pd);
                db.OdemePlaniTaksit.Add(pd);
                db.SaveChanges();

            }

        }
    }
}
