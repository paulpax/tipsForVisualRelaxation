using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace tipsForVisualRelaxation.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter movie's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}