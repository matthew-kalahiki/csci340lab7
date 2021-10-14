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
    public class DetailsModel : PageModel
    {
        private readonly CoolVideoGames.Data.CoolVideoGamesContext _context;

        public DetailsModel(CoolVideoGames.Data.CoolVideoGamesContext context)
        {
            _context = context;
        }

        public VideoGame VideoGame { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VideoGame = await _context.VideoGame.FirstOrDefaultAsync(m => m.ID == id);

            if (VideoGame == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
