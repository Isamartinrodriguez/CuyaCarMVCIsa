using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CuyaCarMVCIsa.Models;


namespace CuyaCarMVCIsa.BDContext
{
    public class CuyaCarsDbContext : DbContext
    {
        public DbSet<Coche> Coche { get; set; }
    }
}