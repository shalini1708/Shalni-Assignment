using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHASE3APPLR.Models;
namespace PHASE3APPLR
{
    public class EmpProfileDAL : IEmpProfileDAL<EmpProfile>
    {

        public bool SaveEmpProfile(EmpProfile empProfile)
        {
            try
            {
                using (EMPDBEntities dbContext = new EMPDBEntities())
                {
                    dbContext.EmpProfiles.Add(empProfile);
                    dbContext.SaveChanges();


                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool DeleteEmpProfile(int code)
        {
            try
            {
                using (EMPDBEntities dbContext = new EMPDBEntities())
                {
                    var employee = dbContext.EmpProfiles.Where(emp => emp.EmpCode == code).FirstOrDefault();
                    if (employee != null)
                    {
                        dbContext.EmpProfiles.Remove(employee);
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateEmpProfile(EmpProfile empProfile)
        {
            try
            {
                using (EMPDBEntities dbContext = new EMPDBEntities())
                {
                    var existEmployee = dbContext.EmpProfiles.Where(emp => emp.EmpCode == empProfile.EmpCode).FirstOrDefault();
                    if (existEmployee != null)
                    {
                        existEmployee.EmpCode = empProfile.EmpCode;
                        existEmployee.EmpName = empProfile.EmpName;
                        existEmployee.DateOfBirth = empProfile.DateOfBirth;
                        existEmployee.Email = empProfile.Email;
                        existEmployee.DeptCode = empProfile.DeptCode;

                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public EmpProfile GetEmpProfile(int code)
        {
            try
            {
                using (EMPDBEntities dbContext = new EMPDBEntities())
                {
                    var existEmployee = dbContext.EmpProfiles.Where(emp => emp.EmpCode == code).FirstOrDefault();
                    if (existEmployee != null)
                    {

                        return existEmployee;
                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<EmpProfile> GetAllEmpProfiles()
        {
            List<EmpProfile> empProfiles = new List<EmpProfile>();
            try
            {
                using (EMPDBEntities dbContext = new EMPDBEntities())
                {
                    var employeeList = dbContext.EmpProfiles.ToList();
                    if (employeeList != null)
                    {
                        return employeeList;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }





    }
}
