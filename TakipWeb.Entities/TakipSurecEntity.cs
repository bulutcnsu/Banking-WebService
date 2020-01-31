using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakipWeb.Entities
{
    public class TakipSurecEntity
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public Nullable<int> DosyaId { get; set; }
        public Nullable<int> SurecKodu { get; set; }

        public TakipDosyaEntity TakipDosya { get; set; }
    }
}
