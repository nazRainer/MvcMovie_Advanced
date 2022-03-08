using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }

        [DataType(DataType.Date)]
        public SelectList? ReleaseDate { get; set; }
        [DataType(DataType.Date)]
        public SelectList? EndDate { get; set; }

        public decimal PriceFilter { get; set; }
        public decimal PriceFilter2 { get; set; }
        public SelectList? Price1 { get; set; }
        public SelectList? Price2 { get; set; }


        public string? Title { get; set; }
    }
}