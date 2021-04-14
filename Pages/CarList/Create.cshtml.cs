using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PS4_5_WstrzykiwanieSerwisów.Data;
using PS4_5_WstrzykiwanieSerwisów.Models;

namespace PS4_5_WstrzykiwanieSerwisów.Pages.CarList
{
    public class CreateModel : PageModel
    {
        private readonly PS4_5_WstrzykiwanieSerwisów.Data.ProductContext _context;

        public CreateModel(PS4_5_WstrzykiwanieSerwisów.Data.ProductContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
