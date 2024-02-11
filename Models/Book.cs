using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class Book
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please enter the book ISBN")]
        [Range(13, 13)]
        public string ISBN { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please enter the book title")]
        [StringLength(225)]
        public string Title { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please select a genre")]
        public byte GenreId { get; set; }
        [ValidateNever]
        public Genre Genre { get; set; } = null!;


        public int AuthorId { get; set; }
        [ValidateNever]
        public Author Author { get; set; } = null!;


        [Required(ErrorMessage = "Please enter the book price")]
        [MinLength(1)]
        public float Price { get; set; }


        [Required(ErrorMessage = "How many books are there")]
        [Range(0, 20)]
        public int Quantity { get; set; }


        public DateTime? ReleaseDate { get; set; }

        public string imageURL { get; set; } = string.Empty;


    }
}
