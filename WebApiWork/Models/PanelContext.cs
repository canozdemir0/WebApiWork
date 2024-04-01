using Microsoft.EntityFrameworkCore;

namespace WebApiWork.Models
{
    public class PanelContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2KUVAQ5\SQLEXPRESS;Initial Catalog=WebApiPanel;Integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}
