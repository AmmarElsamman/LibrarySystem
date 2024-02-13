using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Models
{
    public class LibraryContext : DbContext
    {

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; } = null!;

        public DbSet<Author> Authors { get; set; } = null!;

        public DbSet<Genre> Genres { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Fiction" },
                new Genre { GenreId = 2, Name = "Non-Fiction" },
                new Genre { GenreId = 3, Name = "History" },
                new Genre { GenreId = 4, Name = "Thriller" },
                new Genre { GenreId = 5, Name = "Horror" },
                new Genre { GenreId = 6, Name = "Mystery" },
                new Genre { GenreId = 7, Name = "Biography" },
                new Genre { GenreId = 8, Name = "Romance" },
                new Genre { GenreId = 9, Name = "Novel" },
                new Genre { GenreId = 10, Name = "Short Story" }
            );
        }

    }
}
