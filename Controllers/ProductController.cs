

using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SyncfusionWebApplication1.Models; // Здесь подключите namespace для ваших моделей и контекста данных

public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    // Добавьте другие методы действий для создания, редактирования и удаления продуктов, если необходимо.
}
