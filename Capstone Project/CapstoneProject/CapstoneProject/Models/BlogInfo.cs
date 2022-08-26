namespace CapstoneProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BlogInfo")]
    public partial class BlogInfo
    {
        [Key]
        public int BlogId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(40)]
        public string Subject { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfCreation { get; set; }

        [Required]
        [StringLength(60)]
        public string BlogUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpEmailId { get; set; }
    }
}
