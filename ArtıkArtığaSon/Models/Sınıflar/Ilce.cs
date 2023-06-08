using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class Ilce
    {
        [Key]
        public int IlceID { get; set; }
        public Sehir IlceSehirID { get; set; }
        public string IlceAdi { get; set; }
        public ICollection<Mahalle> Mahalles { get; set; }
        public ICollection<Adres> Adresses { get; set; }
    }
}