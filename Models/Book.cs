namespace radlab3._0.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Book
{
    public int ID { get; set; }

    [Required]
    public string Title { get; set; }

    public string Summary { get; set; }

    public string Publication { get; set; }

    public int AuthorID { get; set; }

    public int PublisherID { get; set; }

    public DateTime DateOfPublication { get; set; }

    [Url(ErrorMessage = "Please enter a valid URL.")]
    public string CoverPageUrl { get; set; }
}
