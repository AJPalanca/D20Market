using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using D20Market.Data;
using D20Market.Models;

namespace D20Market.Pages.Characters
{
    public class IndexModel : PageModel
    {
        private readonly D20MarketContextDb _context;

        public IndexModel(D20MarketContextDb context)
        {
            _context = context;
        }

        public IList<Character> Characters { get; set; } = default!;

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string? searchString, int? pageIndex, string? sortOrder)
        {
            int pageSize = 10;
            int page = pageIndex ?? 1;

            IQueryable<Character> query = _context.Characters.Include(c => c.Player);

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(c =>
                    c.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                    c.Class.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase));
                CurrentFilter = searchString;
            }
            else
            {
                CurrentFilter = "";
            }

            CurrentSort = sortOrder ?? "class_asc";

            query = CurrentSort switch
            {
                "class_desc" => query.OrderByDescending(c => c.Class),
                _ => query.OrderBy(c => c.Class),
            };

            var totalCharacters = await query.CountAsync();
            TotalPages = (int)Math.Ceiling(totalCharacters / (double)pageSize);

            Characters = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            CurrentPage = page;
        }
    }
}
