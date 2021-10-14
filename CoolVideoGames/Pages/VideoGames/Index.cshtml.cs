using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoolVideoGames.Data;
using CoolVideoGames.Models;

namespace CoolVideoGames.Pages.VideoGames
{
    public class IndexModel : PageModel
    {
        private readonly CoolVideoGames.Data.CoolVideoGamesContext _context;

        public IndexModel(CoolVideoGames.Data.CoolVideoGamesContext context)
        {
            _context = context;
        }

        public IList<VideoGame> VideoGame { get;set; }

        public async Task OnGetAsync()
        {
            VideoGame = await _context.VideoGame.ToListAsync();
        }
    }
}
