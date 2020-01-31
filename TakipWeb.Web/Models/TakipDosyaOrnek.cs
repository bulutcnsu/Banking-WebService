using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TakipWeb.Web.Models
{
    public class TakipDosyaOrnek
    {

        public int Id { get; set; }
        public string SubeKodu { get; set; }
        public string MusteriNo { get; set; }
        public string BirimKodu { get; set; }
        //   public Nullable<System.DateTime> DosyaDurumTarihi { get; set; }
        public Nullable<int> IlKodu { get; set; }
        public Nullable<int> IlceKodu { get; set; }
        public Nullable<decimal> Borc { get; set; }
        public Nullable<decimal> TahsilTutari { get; set; }
    }
}
