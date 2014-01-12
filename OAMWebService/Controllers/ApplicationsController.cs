using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
//using System.Net.Http;
using System.Web.Http;
using Dlabs.OAMLib;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Dlabs.Controllers
{
    public class ApplicationsController : ApiController
    {
        List<Application> applications = new List<Application>() { new Application() { ApplicationID = 1, CompanyAddress = "addr1", CompanyName = "CompanyName" } };

        // GET api/<controller>
        public IEnumerable<Application> GetAllApplications()
        {            
            return Application.GetAllApplications();
        }

        // GET api/<controller>/5
        public Application GetApplication(int id)
        {
            var appForm = applications.FirstOrDefault((p) => p.ApplicationID == id);            
            return appForm;
        }


        // POST api/<controller>
        public void Post(Application app)
        {
            app.CreateApplication();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}