using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakipWeb.Entities;
using TakipWeb.Model;

namespace TakipWeb.Business.Operations
{
    public static class TakipDosyaOperations
    {
        public static void DeleteTakipDosya(int id)
        {
            using (var db = new TakipDbEntities())
            {
                TakipDosya td = db.TakipDosya.FirstOrDefault(x => x.Id == id);
                db.TakipDosya.Attach(td);
                db.TakipDosya.Remove(td);
                db.SaveChanges();
            }
        }

        public static void UpdateTakipDosya(TakipDosyaEntity model)
        {
            using (var db = new TakipDbEntities())
            {
                TakipDosya tk = new TakipDosya();
             tk = db.TakipDosya.FirstOrDefault(x => x.Id == model.Id);

                tk.SubeKodu = model.SubeKodu;
                tk.MusteriNo = model.MusteriNo;
                tk.IlKodu = model.IlKodu;
                tk.IlceKodu = model.IlceKodu;
                tk.BirimKodu = model.BirimKodu;
                tk.Borc = model.Borc;
                tk.TahsilTutari = model.TahsilTutari;
                tk.DosyaDurumTarihi = model.DosyaDurumTarihi;

                db.TakipDosya.Attach(tk);
                db.TakipDosya.Add(tk);
                db.SaveChanges();
            }
        }
        public static void InsertTakipDosya(TakipDosyaEntity model)
        {
            using (var db = new TakipDbEntities())
            {
                /*  db.TakipDosya.Attach(model);
                  db.TakipDosya.Add(model);
                  db.SaveChanges();*/

                TakipDosya tk = new TakipDosya();
                tk.SubeKodu = model.SubeKodu;
                tk.MusteriNo = model.MusteriNo;
                tk.IlKodu = model.IlKodu;
                tk.IlKodu = model.IlceKodu;
                tk.BirimKodu = model.BirimKodu;
                tk.Borc = model.Borc;
                tk.TahsilTutari = model.TahsilTutari;
                tk.DosyaDurumTarihi = model.DosyaDurumTarihi;

                db.TakipDosya.Attach(tk);
                db.TakipDosya.Add(tk);
                db.SaveChanges();

            }
        }

        public static List<TakipDosyaEntity> Select(TakipDosyaEntity model)
        {
            using (var db = new TakipDbEntities())
            {
                var dblist = db.TakipDosya.ToList();

                var entityList = new List<TakipDosyaEntity>();
                //return list;

                foreach (var item in dblist)




                {
                    var temp = new TakipDosyaEntity()
                    {
                        Id = item.Id,
                        BirimKodu = item.BirimKodu,
                        SubeKodu=item.SubeKodu,
                        MusteriNo=item.MusteriNo,
                        DosyaDurumTarihi=item.DosyaDurumTarihi,
                        IlKodu=item.IlKodu,
                        IlceKodu=item.IlceKodu,
                        Borc=item.Borc,
                        TahsilTutari=item.TahsilTutari,
                    };

                    if(item.OdemePlani != null && item.OdemePlani.Count > 0)
                    {
                        temp.OdemePlaniVar = true;
                    }

                    entityList.Add(temp);
                }

                return entityList;
            }

        }
    }

}


