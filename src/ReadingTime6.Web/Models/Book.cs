using System.ComponentModel.DataAnnotations;

namespace ReadingTime6.Web.Models
{
    public class Book
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Author { get; set; }
        public string Cover { get; set; }

        // Add a property for rating
        public int Rating { get; set; }

        public Book()
        {

        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public Book(string title, string author, string cover)
        {
            Title = title;
            Author = author;
            Cover = cover.Replace(".jpg",".png");
        }

        // Add a constructor that takes a rating
        public Book(string title, string author, string cover, int rating)
        {
            Title = title;
            Author = author;
            Cover = cover.Replace(".jpg", ".png");
            Rating = rating;
        }

    }

}
