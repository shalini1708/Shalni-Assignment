namespace CapstoneProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminInfo")]
    public partial class AdminInfo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string EmailId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
