using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHASE3APPLR.Models
{
    public class EMPDBEntities : DbContext
    {
        public EMPDBEntities() : base("name=schoolEntities")
        {

        }
        public DbSet<EmpProfile> EmpProfiles { get; set; }
        public DbSet<DeptMaster> DeptMasters { get; set; }


    }
    public class EMSDBInitializer : DropCreateDatabaseIfModelChanges<EMPDBEntities>
    {
        protected override void Seed(EMPDBEntities context)
        {
            var depts = new List<DeptMaster> {

                new DeptMaster { DeptCode=1,DeptName="Hr" },
                new DeptMaster { DeptCode=2,DeptName="Accounts" },

            };
            depts.ForEach(s => context.DeptMasters.Add(s));
            context.SaveChanges();
        }
    }
}
