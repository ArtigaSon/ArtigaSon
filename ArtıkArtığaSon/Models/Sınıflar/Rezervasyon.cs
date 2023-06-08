using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class Rezervasyon
    {
        [Key]
        public int RezervasyonID { get; set; }
        public KisiselBilgiler RezKisBilID { get; set; }
        public Ilan RezIlanID { get; set; }
    }
}