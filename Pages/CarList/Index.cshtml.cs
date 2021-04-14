using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PS4_5_WstrzykiwanieSerwisów.Data;
using PS4_5_WstrzykiwanieSerwisów.Models;

namespace PS4_5_WstrzykiwanieSerwisów.Pages.CarList
{
    public class IndexModel : PageModel
    {
        private readonly PS4_5_WstrzykiwanieSerwisów.Data.ProductContext _context;

        public IndexModel(PS4_5_WstrzykiwanieSerwisów.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
