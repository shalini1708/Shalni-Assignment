namespace CapstoneProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpInfo")]
    public partial class EmpInfo
    {
        [Key]
        public int EmpId { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }

        [DataType(DataType.Password)]
        public int PassCode { get; set; }
    }
}
