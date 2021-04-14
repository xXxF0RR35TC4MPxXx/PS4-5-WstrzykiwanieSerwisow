using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PS4_5_WstrzykiwanieSerwisów.Models;
namespace PS4_5_WstrzykiwanieSerwisów.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Product { get; set; }
    }
}
