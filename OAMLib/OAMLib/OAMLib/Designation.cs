using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dlabs.OAMLib
{
   public class Designation
    {
        public int DesignationID { get; set; }
        public string DesignationName { get; set; }

        public Designation()
        { }

        public int CreateDesignation()
        {
            return 0;
        }
        public int DeleteDesignation()
        {
            return 0;
        }

        public int UpdateDesignation()
        {
            return 0;
        }
        public static List<Designation> GetAllDesignations()
        {
            return null;
        }

        public static Designation GetDesignationByID(int designationID)
        {
            return null;
        }
    }
}
