using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


// square brackets are giving each property information such as the [Key] being the primatry key, [Required] means it is required to add it to the database, and [Range(min,max)] giving it a range of numbers it is allowed to be
namespace ResturauntRater.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Style { get; set; }

        [Required]
        [Range(0f,5f)]
        public float Rating { get; set; }

        [Required]
        [Range(1,5)]
        public int DollarSigns { get; set; }
    }
}