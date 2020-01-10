using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movies
    {

        [Required]
        [StringLength(255)]
        [Range(1,10)]
        public string Name { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public System.DateTime releasedate { get; set; }

        [Required]
        public int numberinstocks { get; set; }
    }
}