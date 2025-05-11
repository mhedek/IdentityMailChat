using IdentityCase.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityCase.Context
{
    public class CaseContext : IdentityDbContext<AppUser> //Benim özelleştirdiğim sınıfıda ilgili usera dahil et
    {
        //Bağlantı Adresi
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-5D42MKKG;initial Catalog=DbCaseEmail;integrated Security=true;trust server certificate=true");
        }
        public DbSet<Message> Messages { get; set; }
    }
}
