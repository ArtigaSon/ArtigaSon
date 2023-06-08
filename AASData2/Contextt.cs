using AASData2.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASData2
{
    public class Contextt : DbContext
    {
        public Contextt() 
        :base("Name=Contextt")
        {

        }   

        public DbSet<kisiselBilgiler> kisiselBilgilers { get; set; }

    }
}
