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

        [Display(Name = "Creator")]

        [Required]
        [StringLength(65, ErrorMessage = "Creator's name cannot be longer than 65 characters")]
        public string Creator { get; set; }

        
        public int MovieID { get; set; }
        //      [Key]

        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
    //   [StringLength(90)]
        
    }
}
