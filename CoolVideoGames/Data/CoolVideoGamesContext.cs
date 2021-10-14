using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoolVideoGames.Models;

namespace CoolVideoGames.Data
{
    public class CoolVideoGamesContext : DbContext
    {
        public CoolVideoGamesContext (DbContextOptions<CoolVideoGamesContext> options)
            : base(options)
        {
        }

        public DbSet<CoolVideoGames.Models.VideoGame> VideoGame { get; set; }
    }
}
