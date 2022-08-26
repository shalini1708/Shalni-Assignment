namespace PHASE3APPLR.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeptMaster")]
    public partial class DeptMaster
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string DeptName { get; set; }

        [Key]
        [Column("virtual EmpProfiles", Order = 2)]
        [StringLength(50)]
        public string virtual_EmpProfiles { get; set; }
    }
}
