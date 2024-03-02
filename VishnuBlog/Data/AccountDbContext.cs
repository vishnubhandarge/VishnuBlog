using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VishnuBlog.Models;

namespace VishnuBlog.Data
{
    public class AccountDbContext: IdentityDbContext
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options) 
            : base(options) { 
        }

        private DbSet<RegisterUser> Register {  get; set; }
        private DbSet<UserLogin> Login { get; set; }
    }

   
}
