using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReactAspx.Models.Data
{
    public class DBNAME : DbContext
    {
        public DbSet<PageDTO> Pages { get; set; }
    }
}