using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = [];

        public void OnGet(
            [FromRoute] int skip = 0,
            [FromRoute] int take = 25)
        {
            var temp = new List<Category>();

            for (var i = 1; i <= 5000; i++)
            {
                temp.Add(
                    item: new Category(
                        i,
                        Title: $"Categoria {i}",
                        Price: i * 18.95M));
            }

            ViewData["Title"] = "Categorias";
            Categories = temp.Skip(skip)
                             .Take(take)
                             .ToList();
        }

        public record Category(int Id, string Title, decimal Price);
    }
}
