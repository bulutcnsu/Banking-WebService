using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakipWeb.Entities
{
    public class OdemePlaniTaksitEntity
    {
        public int Id { get; set; }
        public Nullable<int> OdemePlaniId { get; set; }
        public Nullable<int> TaksitNo { get; set; }
        public Nullable<System.DateTime> TaksitTarihi { get; set; }
        public Nullable<decimal> TaksitTutari { get; set; }
        public Nullable<decimal> TahsilTutari { get; set; }
        public OdemePlaniEntity OdemePlani { get; set; }
    }
}
