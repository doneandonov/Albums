using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VezbiJuniIspit.Models
{
    public class MusicStoreDb : DbContext
    {
        public DbSet<Albums> Albums { get; set; }
    }
}