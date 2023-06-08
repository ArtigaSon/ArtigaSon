using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Context : DbContext
    {
        public Context()
        : base("Name=Context")
        {
        }

        public DbSet<kisiselBilgiler> kisiselBilgilers { get; set; }
    }
}
