using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using radlab3._0.Models; // Adjust namespace if needed

namespace radlab3._0.Data // Use your actual namespace here
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                       serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any books already in the database
                if (context.Books.Any())
                {
                    return;   // Database has already been seeded
                }

                // Seed the database with initial book data
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Sample Book 1",
                        Summary = "This is the first sample book.",
                        Publication = "Publisher 1",
                        AuthorID = 1,
                        PublisherID = 1,
                        DateOfPublication = DateTime.Now,
                        CoverPageUrl = "/images/pic.jpg"  // Path to the cover image
                    },
                    new Book
                    {
                        Title = "Sample Book 2",
                        Summary = "This is the second sample book.",
                        Publication = "Publisher 2",
                        AuthorID = 2,
                        PublisherID = 2,
                        DateOfPublication = DateTime.Now,
                        CoverPageUrl = "/images/pic.jpg"  // Path to another cover image
                    }
                );

                context.SaveChanges(); // Save the data to the database
            }
        }
    }
}