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
    public class DetailsModel : PageModel
    {
        private readonly PS4_5_WstrzykiwanieSerwisów.Data.ProductContext _context;

        public DetailsModel(PS4_5_WstrzykiwanieSerwisów.Data.ProductContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
