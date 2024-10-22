using Bulky.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Tools;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
       public ApplicationDbContext()
       {
            
       }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YOUR_DB_CONNECTION_STRING");
        }
        
        

        public DbSet<Category> jatin_Categories {get;set;}
        public DbSet<Product> jatin_Products {get;set;}
        public DbSet<Company> jatin_Companies {get;set;}
        public DbSet<ShoppingCart> jatin_ShoppingCarts {get;set;}
        public DbSet<ApplicationUser> jatin_ApplicationUsers {get;set;}
        public DbSet<OrderHeader> jatin_OrderHeaders {get;set;}
        public DbSet<OrderDetail> jatin_OrderDetails {get;set;}
        
       

    }

} 
