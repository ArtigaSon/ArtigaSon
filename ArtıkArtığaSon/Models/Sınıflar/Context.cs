using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ArtıkArtığaSon.Models.Sınıflar
{
    public class Context: DbContext
    {
        public DbSet<Sehir> Sehirs { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<Mahalle> Mahalles { get; set; }
        public DbSet<Adres> Adresses { get; set; }
        public DbSet<KisiselBilgiler> KisiselBilgilers { get; set; }
        public DbSet<UyeTuru> UyeTurus { get; set; }
        public DbSet<KurumsalUye> KurumsalUyes { get; set; }
        public DbSet<Ilan> Ilans { get; set; }
        public DbSet<Rezervasyon> Rezervasyons { get; set; }
    }
}