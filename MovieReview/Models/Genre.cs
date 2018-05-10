using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReview.Models
{
    public class Genre
    {
        public int GenreID { get; set; }


        [Display(Name = "Genre Type")]
        [Required]
        [StringLength(50, ErrorMessage = "Genre name cannot be longer than 50 characters")]
        public string GenreName { get; set; }
    }
}
