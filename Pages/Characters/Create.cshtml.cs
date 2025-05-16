using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using D20Market.Models;

namespace D20Market.Pages_Characters
{
    public class CreateModel : PageModel
    {
        private readonly D20Market.Data.D20MarketContextDb _context;

        public CreateModel(D20Market.Data.D20MarketContextDb context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PlayerId"] = new SelectList(_context.Players, "PlayerId", "Email");
            return Page();
        }

        [BindProperty]
        public Character Character { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Characters.Add(Character);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
