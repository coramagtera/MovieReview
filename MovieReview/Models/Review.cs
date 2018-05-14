using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieReview.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        [Range(0,100)]
        public int Rating { get; set; }

        public string WrittenReview { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        //FK
        public int MovieID { get; set; }
        

        //Nav prop
        public virtual Movie Movie { get; set; }
        
    }
}
