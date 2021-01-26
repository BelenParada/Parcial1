using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PryUserParadaMB.Models 
{
    using System.Data.Entity;
    public class DataContext: DbContext
    {
        public DataContext() : base("defaultConnection")
        {

        }
        public System.Data.Entity.DbSet<PryUserParadaMB.Models.empresarios> empresarios { get; set; }
    }

        

    
}