using BookClub2.Models;
using Microsoft.EntityFrameworkCore;


namespace BookClub2.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BooksRead> BookReads { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public ApplicationDbContext()
        {
            Users.Load();
            Books.Load();
            BookReads.Load();
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\BookClub2-master\BookClubDb.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
