using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelfApp.Models
{
    public class Author
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return $"{FirstName} + {LastName}"; }
        }

        public string Penname { get; set; }

        [Display(Name = "Preferred Genre")]
        public string PreferredGenre { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public int UserId { get; set; }
    }
}
