using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoolVideoGames.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolVideoGames.Models
{
	public class SeedData
	{
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CoolVideoGamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CoolVideoGamesContext>>()))
            {
                // Look for any movies.
                if (context.VideoGame.Any())
                {
                    return;   // DB has been seeded
                }

                context.VideoGame.AddRange(
                    new VideoGame
                    {
                        Title = "Horizon Zero Dawn",
                        Developer = "Guerrilla Games",
                        ReleaseDate = DateTime.Parse("2017-2-17"),
                        Genre = "Action role-playing",
                    },

                new VideoGame
                {
                    Title = "Minecraft",
                    Developer = "Mojang Studios",
                    ReleaseDate = DateTime.Parse("2011-11-18"),
                    Genre = "Sandbox",
                }, 
                new VideoGame
                {
                    Title = "Grand Theft Auto V",
                    Developer = "Rockstar Games",
                    ReleaseDate = DateTime.Parse("2013-9-17"),
                    Genre = "Action adventure",
                }



                );
                context.SaveChanges();
            }
        }
    }
}
