using System.Diagnostics.Eventing.Reader;
using radlab3._0.Models;

using Microsoft.EntityFrameworkCore;
using radlab3._0.Models;  // This is the namespace for the Models folder

namespace radlab3._0.Data  // Your actual namespace for the Data folder
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }  // DbSet for the Book model
    }
}
