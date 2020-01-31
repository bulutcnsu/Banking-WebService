using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TakipWeb.Web.Models
{
    public class OdemePlaniWeb
    {


        public int Id { get; set; }
        public int DurumKodu { get; set; }
        public string MusteriNo { get; set; }

        [Required]
        [Display(Name = "MÜŞTERİ NO")]
        public string Name { get; set; }

        // This property will hold a state, selected by user
        [Required]
        [Display(Name = "Taksit Sayısı")]
        public string State { get; set; }

        // This property will hold all available states for selection
        public IEnumerable<SelectListItem> States { get; set; }




    }
}