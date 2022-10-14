using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcRadios.Models;

namespace Radios.Data
{
    public class RadiosContext : DbContext
    {
        public RadiosContext (DbContextOptions<RadiosContext> options)
            : base(options)
        {
        }

        public DbSet<MvcRadios.Models.radios> radios { get; set; }
    }
}
