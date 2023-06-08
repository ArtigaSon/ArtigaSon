using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class KurumsalUye
    {
        [Key]
        public int KurUyeID { get; set; }
        public KisiselBilgiler KurKisBilID { get; set; }
        public string KurumAdi { get; set; }
        public string KurumTuru { get; set; }
        public ICollection<Ilan> Ilans { get; set; }
    }
}