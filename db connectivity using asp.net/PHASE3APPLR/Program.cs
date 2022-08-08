using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHASE3APPLR.Models;
namespace PHASE3APPLR
{
    internal class Program
    {
        static void Main()
        {
            using (var context = new EMPDBEntities())
            {
                Database.SetInitializer<EMPDBEntities>(new EMSDBInitializer());

                var depts = context.DeptMasters.ToList();

                foreach (var dept in depts)
                {
                    Console.WriteLine($"Code={dept.DeptCode}\tName={dept.DeptName}");
                }

                Console.ReadKey();
            }
        }
    }
}
