using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PS4_5_WstrzykiwanieSerwisów.Data;
using PS4_5_WstrzykiwanieSerwisów.Models;
using PS4_5_WstrzykiwanieSerwisów.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS4_5_WstrzykiwanieSerwisów.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductContext _context;
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService, ProductContext context)
        {
            _logger = logger;
            ProductService = productService;
            _context = context;
        }
        public IList<Product> CarList { get; set; }
        public void OnGet()
        {
            CarList = _context.Product.ToList();
            Products = ProductService.GetProducts();
        }
    }
}
