using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class BireyselUye
    {
        [Key]
        public int BirUyeID { get; set; }
        public KisiselBilgiler BirKisBilID { get; set; }
        public UyeTuru BirUyeTuruID { get; set; }
        public Adres BirAdresID { get; set; }
        public ICollection<Rezervasyon> Rezervasyons { get; set; }
    }
}