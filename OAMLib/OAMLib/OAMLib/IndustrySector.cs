using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dlabs.OAMLib
{
    public class IndustrySector
    {
        public int IndustrySectorID { get; set; }
        public string IndustrySectorName { get; set; }

        public IndustrySector()
        {

        }
        public int CreateIndustrySector()
        {
            return 0;
        }
        public int DeleteIndustrySector()
        {
            return 0;
        }

        public int UpdateIndustrySector()
        {
            return 0;
        }
        public static List<Application> GetAllIndustrySectors()
        {
            return null;
        }

        public static Application GetIndustrySectorByID(int ApplicationID)
        {
            return null;
        }
    }
}
