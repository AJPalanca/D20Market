using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using D20Market.Data;
using D20Market.Models;

namespace D20Market.Pages_Characters
{
    public class DeleteModel : PageModel
    {
        private readonly D20Market.Data.D20MarketContextDb _context;

        public DeleteModel(D20Market.Data.D20MarketContextDb context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FindAsync(id);
            if (character != null)
            {
                Character = character;
                _context.Characters.Remove(Character);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
