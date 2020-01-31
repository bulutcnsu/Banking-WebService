using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakipWeb.Entities
{
    public class TakipDosyaEntity
    {
        public int Id { get; set; }
        public string SubeKodu { get; set; }
        public string MusteriNo { get; set; }
        public string BirimKodu { get; set; }

        public Nullable<System.DateTime> DosyaDurumTarihi { get; set; }
        public Nullable<int> IlKodu { get; set; }
        public Nullable<int> IlceKodu { get; set; }
        public Nullable<decimal> Borc { get; set; }
        public Nullable<decimal> TahsilTutari { get; set; }
        public List<OdemePlaniEntity> OdemePlani { get; set; }
        public List<TakipSurecEntity> TakipSurec { get; set; }
        public bool OdemePlaniVar { get; set; }
        public int TaksitNo { get; set; }
        public int TaksitTutari { get; set; }
       
        public Nullable<System.DateTime> TaksitTarihi { get; set; }
        public bool DurumKodu { get; set; }
        public int DosyaId { get; set; }

    }
}
