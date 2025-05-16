using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using D20Market.Data;
using D20Market.Models;

namespace D20Market.Pages_Characters
{
    public class DetailsModel : PageModel
    {
        private readonly D20Market.Data.D20MarketContextDb _context;

        public DetailsModel(D20Market.Data.D20MarketContextDb context)
        {
            _context = context;
        }

        public Character Character { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FirstOrDefaultAsync(m => m.CharacterId == id);

            if (character is not null)
            {
                Character = character;

                return Page();
            }

            return NotFound();
        }
    }
}
