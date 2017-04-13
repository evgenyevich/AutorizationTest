using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutorizationTest.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext():base("SportStore")
        {
            
        }
       

        public System.Data.Entity.DbSet<AutorizationTest.Models.Product> Products { get; set; }
    }
}