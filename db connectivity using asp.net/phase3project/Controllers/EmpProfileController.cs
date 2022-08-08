using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using phase3project.Models;
using phase3project;
using Newtonsoft.Json;
//using System.Web.Http.Cors;
namespace phase3project.Controllers
{
   // [EnableCors(origins: "http://localhost:60608/", headers: "*", methods: "*")]
    public class EmpProfileController : ApiController
    {
        EmpProfileBLL empProfileBLL = new EmpProfileBLL();

        [HttpGet]
        [Route("Emp/GetAll")]
        public HttpResponseMessage GetEmpProfiles()
        {
            var empProfiles = empProfileBLL.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, empProfiles);
        }
        [HttpGet]
        [Route("Emp/GetById/{id}")]
        public HttpResponseMessage GetByCode(int id)
        {
            var empProfile = empProfileBLL.GetEmpByCode(id);
            if (empProfile != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, empProfile);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

        }

        [HttpPost]
        [Route("Emp/SaveEmp")]
        public HttpResponseMessage PostEmpProfile([FromBody] EmpProfile empProfile)
        {
            var saveResult = empProfileBLL.AddEmployee(empProfile);
            if (saveResult)
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpDelete]
        [Route("Emp/DeleteEmp/{id}")]
        public HttpResponseMessage DeleteEmpProfile(int id)
        {
            var empProfile = empProfileBLL.GetEmpByCode(id);
            if (empProfile != null)
            {
                var deleteResult = empProfileBLL.DeleteEmployee(id);
                if (deleteResult)
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpPut]
        [Route("Emp/UpdateEmp")]
        public HttpResponseMessage PutEmpProfile([FromBody] EmpProfile empProfile)
        {
            var employee = empProfileBLL.GetEmpByCode(empProfile.EmpCode);
            if (employee != null)
            {
                var updateEmpProfile = empProfileBLL.UpdateEmployee(empProfile);
                if (updateEmpProfile)
                {
                    return Request.CreateResponse(HttpStatusCode.Accepted);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }
    }
}
