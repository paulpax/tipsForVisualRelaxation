using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tipsForVisualRelaxation.Models;
using System.ComponentModel.DataAnnotations;

namespace tipsForVisualRelaxation.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        //exclude ID field error
        public int? ID { get; set; }
        [Required(ErrorMessage = "Please enter movie's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }
        [Display(Name = "Release Date")]

        [Required]
        public DateTime? ReleaseDate { get; set; }

        public string Title
        {
           get
           {
                if (ID != 0)
                   return "Edit Movie";

                return "New Movie";
          }
       }

        public MovieFormViewModel()
        {
            ID = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            ID = movie.ID;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            GenreId = movie.GenreId;
        }
    }
}