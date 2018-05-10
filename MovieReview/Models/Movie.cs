using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReview.Models
{
    public class Movie:Genre //movie inherits from genre
    {
        public int MovieID { get; set; }


        public string Title { get; set; }

        public string Length { get; set; }

        public string Rating { get; set; }



    }
}
