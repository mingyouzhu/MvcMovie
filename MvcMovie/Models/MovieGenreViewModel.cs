using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;

        // containing the list of genre. This will allow the user to select a genre from the list.
        public SelectList genres;

        // which contains the selected genre.
        public string movieGenre { get; set; }
    }
}
