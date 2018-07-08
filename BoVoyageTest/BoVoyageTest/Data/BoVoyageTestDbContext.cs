using BoVoyageTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoVoyageTest.Data
{
    public class BoVoyageTestDbContext : DbContext
    {
        public BoVoyageTestDbContext() : base ("BoVoyageTest")
        {
        }

        public System.Data.Entity.DbSet<BoVoyageTest.Models.Destination> Destinations { get; set; }
    }
}