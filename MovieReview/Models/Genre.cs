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
        
        [Required]
        [Display(Name = "Genre Type")]
        [StringLength(50, MinimumLength =3)]
        public string GenreName { get; set; }

        //nav prop
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
