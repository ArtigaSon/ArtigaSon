using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASData2.Entities
{
    [Table("Bilgiler")]
    public class kisiselBilgiler
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int TCNO { get; set; }
        public int Telefon { get; set; }
        public string Cinsiyet { get; set; }
        public string Email { get; set; }
        public int Sifre { get; set; }
    }
}
