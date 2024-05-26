using Api.Challenge.Books.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Challenge.Books.Data;

public class BookStoreContext : DbContext
{
    public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
    {
    }
    
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .Property(l => l.Genres)
            .HasConversion(g => string.Join(',', g),
            g => g.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());
    }
}