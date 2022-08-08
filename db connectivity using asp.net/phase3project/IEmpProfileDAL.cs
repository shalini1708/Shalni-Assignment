using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phase3project.Models;
namespace phase3project
{
    public interface IEmpProfileDAL<EmpProfile>
    {
        bool SaveEmpProfile(EmpProfile empProfile);
        bool DeleteEmpProfile(int code);

        bool UpdateEmpProfile(EmpProfile empProfile);

        EmpProfile GetEmpProfile(int code);

        List<EmpProfile> GetAllEmpProfiles();
    }
}
