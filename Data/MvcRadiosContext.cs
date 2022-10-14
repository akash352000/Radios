using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcRadios.Models;

namespace MvcRadios.Data
{
    public class MvcRadiosContext : DbContext
    {
        public MvcRadiosContext(DbContextOptions<MvcRadiosContext> options)
            : base(options)
        {
        }

        public DbSet<radios> Radios { get; set; }
    }
  
}
