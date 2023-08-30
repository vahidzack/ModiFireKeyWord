using Microsoft.AspNetCore.Mvc;
using ModiFireKeyWord.Models;

namespace ModiFireKeyWord.Controllers
{
    public class KeywordController : Controller
    {
        public IActionResult Index()
        {
            List<Keyword> keywords = KeywordRepository.GetKeywords();
            return View(keywords);
        }

        public IActionResult Search(string query)
        {
            List<Keyword> keywords = KeywordRepository.GetKeywords()
                .Where(k => k.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                .ToList();
            return PartialView("_SearchResults", keywords);
        }
    }
}
