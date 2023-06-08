using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class Sehir
    {
        [Key]
        public int SehirID { get; set; }
        public string SehirName { get; set; }
        public ICollection<Ilce> Ilces { get; set; }
        public ICollection<Mahalle> Mahalles { get; set; }
        public ICollection<Adres> Adresses { get; set; }
    }
}