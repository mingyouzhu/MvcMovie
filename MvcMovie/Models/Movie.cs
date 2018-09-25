using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
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
    }
}
