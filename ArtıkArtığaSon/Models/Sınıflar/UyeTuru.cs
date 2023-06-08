using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class UyeTuru
    {
        [Key]
        public int UyeTuruID { get; set; }
        public string UyeTurleri { get; set; }
        public ICollection<KisiselBilgiler> KisiselBilgilers { get; set; }
    }
}