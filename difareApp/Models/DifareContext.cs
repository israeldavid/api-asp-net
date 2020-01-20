using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace difareApp.Models
{
    public class DifareContext : DbContext
    {
        public DifareContext(DbContextOptions<DifareContext> options)
            : base(options)
        {
        }

        public DbSet<DifareContext> BannerItems { get; set; }

    }
}
