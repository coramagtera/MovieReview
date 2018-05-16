using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReview.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [Required]
        [StringLength(65, MinimumLength =2)]
        public string Title { get; set; }
        
        public string Length { get; set; }

        //FK
        public int GenreID { get; set; }

        //nav prop
        public virtual Genre Genre { get; set; }
        public virtual ICollection<Review> Review { get; set; }


    }
}
