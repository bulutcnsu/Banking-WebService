

namespace TakipWeb.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TakipSurec
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public Nullable<int> DosyaId { get; set; }
        public Nullable<int> SurecKodu { get; set; }
    
        public virtual TakipDosya TakipDosya { get; set; }
    }
}
