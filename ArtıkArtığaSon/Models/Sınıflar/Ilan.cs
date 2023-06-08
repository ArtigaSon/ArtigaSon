using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class Ilan
    {
        [Key]
        public int IlanID { get; set; }
        public KurumsalUye IlanKurUyeID { get; set; }
        public string IlanTarih { get; set; }
        public string IlanSaat { get; set; }
        public int IlanAdet { get; set; }
        public string IlanUrunAdi { get; set; }
        public ICollection<Rezervasyon> Rezervasyons { get; set; }
    }
}