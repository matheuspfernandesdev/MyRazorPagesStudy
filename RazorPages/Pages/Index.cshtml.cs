using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Category> Categories { get; set; } = new();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            for (var i = 0; i <= 100; i++)
            {
                Categories.Add(
                    item: new Category(
                        i,
                        Title: $"Categoria {i}",
                        Price: i * 18.95M));
            }
        }

        public record Category(int Id, string Title, decimal Price);
    }
}
