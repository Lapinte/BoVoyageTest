using BoVoyageTest.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BoVoyageTest.Migrations
{
    public class Configuration : DbMigrationsConfiguration<BoVoyageTestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}