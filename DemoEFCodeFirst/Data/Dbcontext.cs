using DemoEFCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEFCodeFirst.Data
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions<Dbcontext> options) 
            : base(options) 
        { 
        }

        public virtual DbSet<Bill> Bills { get; set; }

        public virtual DbSet<BillDetail> BillDetails { get; set; }

        public virtual DbSet<ProductDetail> ProductDetails { get; set; }

        public virtual DbSet<Product> Products { get; set; }
    }
}
