using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phase3project;
using phase3project.Models;
namespace phase3project
{
    public class EmpProfileBLL
    {
        EmpProfileDAL EmpProfileDAL = new EmpProfileDAL();
        public bool AddEmployee(EmpProfile empProfile)
        {
            //Your additional logic goes here         

            return EmpProfileDAL.SaveEmpProfile(empProfile);
        }

        public bool DeleteEmployee(int code)
        {
            return EmpProfileDAL.DeleteEmpProfile(code);
        }

        public bool UpdateEmployee(EmpProfile empProfile)
        {
            return EmpProfileDAL.UpdateEmpProfile(empProfile);
        }

        public EmpProfile GetEmpByCode(int code)
        {
            return EmpProfileDAL.GetEmpProfile(code);
        }

        public List<EmpProfile> GetAll()
        {
            return EmpProfileDAL.GetAllEmpProfiles();
        }
    }


}
