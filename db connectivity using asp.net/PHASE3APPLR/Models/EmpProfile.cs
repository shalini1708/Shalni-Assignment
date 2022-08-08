namespace PHASE3APPLR.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpProfile")]
    public partial class EmpProfile
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DateOfBirth { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string EmpName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptCode { get; set; }

        [Key]
        [Column("virtual DeptMaster", Order = 5)]
        [StringLength(50)]
        public string virtual_DeptMaster { get; set; }
    }
}
