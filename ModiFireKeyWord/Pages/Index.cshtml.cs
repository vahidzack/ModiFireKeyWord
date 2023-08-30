using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModiFireKeyWord.Models;

namespace ModiFireKeyWord.Pages.Keyword
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        public List<Models.Keyword> SearchResults { get; set; }

        public void OnGet()
        {
            if (!string.IsNullOrEmpty(SearchQuery))
            {
                SearchResults = KeywordRepository.GetKeywords()
                    .Where(k => k.Name.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
        }


    }
}
