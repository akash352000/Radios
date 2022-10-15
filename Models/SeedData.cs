using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcRadios.Data;

namespace MvcRadios.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcRadiosContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcRadiosContext>>()))
            {
                // Look for any movies.
                if (context.Radios.Any())
                {
                    return;   // DB has been seeded
                }

                context.Radios.AddRange(
                    new radios
                    {
                        Name = "saregama 01",
                        LaunchDate = DateTime.Parse("2018-2-10"),
                        company = "carvan",
                        Price = 250,
                        type = "wooden",
                        Generation = 9,
                        Rating = 3
                    },

                    new radios
                    {
                        Name = "Icom IC 705",
                        LaunchDate = DateTime.Parse("2008-5-15"),
                        company = "Icom",
                        Price = 150,
                        type = "Fiber",
                        Generation = 6,
                        Rating = 4
                    },
                    new radios
                    {
                        Name = "FT991A",
                        LaunchDate = DateTime.Parse("1993-9-20"),
                        company = "Yaesy",
                        Price = 90,
                        type = "steel",
                        Generation = 3, 
                        Rating = 4
                    },
                    new radios
                    {
                        Name = "Revo 1",
                        LaunchDate = DateTime.Parse("2004-3-13"),
                        company = "Revo Radio",
                        Price = 140,
                        type = "wooden",
                        Generation = 5,
                        Rating = 3
                    },
                    new radios
                    {
                        Name = "Reva super CD",
                        LaunchDate = DateTime.Parse("2011-2-10"),
                        company = "Revo Radio",
                        Price = 110,
                        type = "wooden",
                        Generation = 5, 
                        Rating = 2
                    },
                    new radios
                    {
                        Name = "Ruark R1MK3",
                        LaunchDate = DateTime.Parse("2018-2-10"),
                        company = "Ruark Audio",
                        Price = 800,
                        type = "luxurious wooden",
                        Generation = 10, 
                        Rating = 5
                    },
                    new radios
                    {
                        Name = "Robort Radio 93I",
                        LaunchDate = DateTime.Parse("2007-12-1"),
                        company = "Robort Radio",
                        Price = 230,
                        type = "steel body",
                        Generation = 10, 
                        Rating = 4
                    },
                    new radios
                    {
                        Name = "Pure N5",
                        LaunchDate = DateTime.Parse("2000-11-20"),
                        company = "Pure Radio",
                        Price = 300,
                        type = "Woollen cover",
                        Generation = 11, 
                        Rating = 5
                    },
                    new radios
                    {
                        Name = "VQ retro MK11",
                        LaunchDate = DateTime.Parse("2019-8-20"),
                        company = "VQ",
                        Price = 450,
                        type = "wooden",
                        Generation = 2, 
                        Rating = 4
                    },
                    new radios
                    {
                        Name = "Tivoli Model 1BT",
                        LaunchDate = DateTime.Parse("2007-5-3"),
                        company = "Tivoli Audio",
                        Price = 190,
                        type = "steel",
                        Generation = 9,
                        Rating = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
