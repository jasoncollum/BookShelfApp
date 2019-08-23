using System;
using System.ComponentModel.DataAnnotations;

namespace BookShelfApp.Models
{
    public class Book
    {
        [Required]
        [MinLength(10), MaxLength(13)]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public int AuthorId { get; set; }

       [Required]
        public int UserID { get; set; }

        [Required]
        public ApplicationUser Owner { get; set; }
    }
}