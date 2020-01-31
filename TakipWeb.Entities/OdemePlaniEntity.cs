using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakipWeb.Entities
{
    public class OdemePlaniEntity
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public Nullable<bool> DurumKodu { get; set; }
        public Nullable<int> DosyaId { get; set; }

        public TakipDosyaEntity TakipDosya { get; set; }
        public List<OdemePlaniTaksitEntity> OdemePlaniTaksit { get; set; }
    }
}
