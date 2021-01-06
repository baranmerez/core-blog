using Microsoft.EntityFrameworkCore;

namespace Blogs.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogsCategories> BlogsCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogsCategories>()
            .HasKey(c => new { c.BlogsId, c.CategoryName });

            modelBuilder.Entity<BlogsCategories>()
                .HasOne(c => c.Blog)
                .WithMany(b => b.BlogsCategories)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BlogsCategories>()
                .HasOne(c => c.Category)
                .WithMany(b => b.BlogsCategories)
                .OnDelete(DeleteBehavior.Cascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=CoreBlogDB;Integrated Security=True");
        }

    }
}
