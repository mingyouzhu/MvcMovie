using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {

        /*
        // The ID field is required by the database for the primary key.
        public int ID { get; set; }

        public string Title { get; set; }

        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")] // specifies what to display for the name of a field
        [DataType(DataType.Date)] // specifies the type of the data field
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        // [Column(TypeName = "decimal(18,2)")] data annotation is required so Entity Framwork Core
        // can correctly map [Price] to currency in the databse.
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Rating { get; set; }
        */

        public int ID { get; set; }

        [StringLength(60,MinimumLength = 3)]  // indicates must have a value.
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date"),DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        // the [Range] attribute constraints a value to within a specified range.
        [Range(1,100),DataType(DataType.Currency)]               
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        // the [RegularExpression] is used to limit what characters can be input.
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"),Required,StringLength(30)] 
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9]""'\s-]$"),StringLength(5),Required]
        public string Rating { get; set; }
    }
}