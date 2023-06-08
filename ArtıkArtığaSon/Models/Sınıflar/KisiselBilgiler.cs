using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class KisiselBilgiler
    {
        [Key]
        public int KisBilID { get; set; }
        public UyeTuru KBUyeTuruID { get; set; }
        public string Isım { get; set; }
        public string SoyIsım { get; set; }
        public string Kimlik { get; set; }
        public string Telefon { get; set; }
        public string Cinsiyet { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public string KisAdres { get; set; }

        public ICollection<KurumsalUye> KurumsalUyes { get; set; }
        public ICollection<Rezervasyon> Rezervasyons { get; set; }
    }
}