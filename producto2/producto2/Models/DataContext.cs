using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace producto2.Models
{
    public class DataContext : DbContext
    {
        public DataContext():base("DefaultConnection") 
        {

        }

        public System.Data.Entity.DbSet<producto2.Models.producto> productoes { get; set; }
    }
}