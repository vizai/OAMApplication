using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Dlabs.OAMLib
{
   public class Application
    {
        public int ApplicationID { get; set; }
        public string ApplicationCode { get; set; }
        public string CompanyName { get; set; }
        public string IndustrySector { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactDesignation { get; set; }
        public string PrimaryContactEmail { get; set; }
        public string PrimaryContactPhone { get; set; }
        public string CompanyAddress { get; set; }
        public string BPlanFile { get; set; }
        public string IPAddress { get; set; }
        public List<Question> Questions { get; set; }
        public List<Contact> Contacts { get; set; }

        public Application()
        {
            ApplicationID = 0;
            ApplicationCode = string.Empty;
            CompanyName = string.Empty;
            IndustrySector = string.Empty;
            PrimaryContactName = string.Empty;
            PrimaryContactEmail = string.Empty;
            PrimaryContactPhone = string.Empty;
            PrimaryContactDesignation = string.Empty;
            BPlanFile = string.Empty;
            IPAddress= string.Empty;
            Questions=null;
            Contacts = null;
        }

        public int CreateApplication()
        {
            string con = ConfigurationManager.ConnectionStrings["OAMConnection"].ToString();
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                //Generate Unique ApplicationCode
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var random = new Random();
                this.ApplicationCode =  new string(
                    Enumerable.Repeat(chars, 8)
                              .Select(s => s[random.Next(s.Length)])
                              .ToArray());

                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand("USP_CREATEAPPLICATION", sqlCon);
                sqlCom.Parameters.Add(new SqlParameter("@ApplicationCode", this.ApplicationCode));
                sqlCom.Parameters.Add(new SqlParameter("@CompanyName", this.CompanyName));
                sqlCom.Parameters.Add(new SqlParameter("@IndustrySector", this.IndustrySector));
                sqlCom.Parameters.Add(new SqlParameter("@PrimaryContactName", this.PrimaryContactName));
                sqlCom.Parameters.Add(new SqlParameter("@PrimaryContactDesignation", this.PrimaryContactDesignation));
                sqlCom.Parameters.Add(new SqlParameter("@PrimaryContactEmail", this.PrimaryContactEmail));
                sqlCom.Parameters.Add(new SqlParameter("@PrimaryContactPhone", this.PrimaryContactPhone));
                sqlCom.Parameters.Add(new SqlParameter("@CompanyAddress", this.CompanyAddress));
                sqlCom.Parameters.Add(new SqlParameter("@BPlanFile", this.BPlanFile));
                sqlCom.Parameters.Add(new SqlParameter("@IPAddress", this.IPAddress));
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.ExecuteNonQuery();
                sqlCon.Close();
                //get applicationid
                //insert contact 

            }
            return 0;
        }
        public int DeleteApplication()
        {
            return 0;
        }

        public int UpdateApplication()
        {
            return 0;
        }
        public static List<Application> GetAllApplications()
        {
            List<Application> listApps = new List<Application>();
            Application app;
            string con = ConfigurationManager.ConnectionStrings["OAMConnection"].ToString();
            using (SqlConnection sqlCon = new SqlConnection(con))
            {

                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand("Select * from Application", sqlCon);
                SqlDataReader dr= sqlCom.ExecuteReader();

                while(dr.Read())
                {
                    app = new Application();
                    app.ApplicationCode = dr["ApplicationCode"].ToString();
                    app.CompanyName = dr["CompanyName"].ToString();
                    app.IndustrySector = dr["IndustrySector"].ToString();
                    app.PrimaryContactName = dr["PrimaryContactName"].ToString();
                    app.PrimaryContactDesignation = dr["PrimaryContactDesignation"].ToString();
                    app.PrimaryContactEmail = dr["PrimaryContactEmail"].ToString();
                    app.PrimaryContactPhone = dr["PrimaryContactPhone"].ToString();
                    listApps.Add(app);
                }
                sqlCon.Close();
                //get applicationid
                //insert contact 

            }
            return listApps;
        }

        public static List<Application> GetApplicationsByIndustry(int IndustrySectorID)
        {
            return null;
        }
        public static Application GetApplicationsByID(int ApplicationID)
        {
            return null;
        }
    }
}
