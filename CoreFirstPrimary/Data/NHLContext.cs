using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CoreFirstPrimary.Models.NHL;

namespace CoreFirstPrimary.Data
{
    public class NHLContext :DbContext
    {
        public NHLContext()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}