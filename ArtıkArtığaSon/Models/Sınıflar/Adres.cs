using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class Adres
    {

        [Key]
        public int AdresID { get; set; }
        public Sehir AdresSehirID { get; set; }
        public Ilce AdresIlceID { get; set; }
        public Mahalle AdresMahID { get; set; }
        public ICollection<KurumsalUye> KurumsalUyes { get; set; }
    }
}