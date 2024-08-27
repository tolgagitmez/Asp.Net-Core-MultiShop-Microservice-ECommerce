using Microsoft.EntityFrameworkCore;
using MultiShop.Comment.Entities;

namespace MultiShop.Comment.Context
{
    public class CommentContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1436; initial Catalog=CommentDb; User=sa; Password=132707Asd.; TrustServerCertificate=True;");
        }

        public DbSet<UserComment> UserComments { get; set; }
    }
}
