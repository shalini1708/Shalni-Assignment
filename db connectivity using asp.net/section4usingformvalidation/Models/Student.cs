using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace section4usingformvalidation.Models
{
    public class Student
    {
        [Required]
        [StringLength(100, ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string Class { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required]
        [Range(5, 14)]
        public int Age { get; set; }
    }
}






