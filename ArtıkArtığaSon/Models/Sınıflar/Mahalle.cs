using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class Mahalle
    {
        [Key]
        public int MahalleID { get; set; }
        public Sehir MahSehirID { get; set; }
        public Ilce MahIlceID { get; set; }
        public string MahalleAdi { get; set; }
        public ICollection<Adres> Adresses { get; set; }
    }
}