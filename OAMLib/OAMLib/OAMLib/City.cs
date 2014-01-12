using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dlabs.OAMLib
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }

        public City()
        {

        }

        public int CreateCity()
        {
            return 0;
        }
        public int DeleteCity()
        {
            return 0;
        }

        public int UpdateCity()
        {
            return 0;
        }
        public static List<City> GetAllCities()
        {
            return null;
        }


        public static City GetCityID(int ApplicationID)
        {
            return null;
        }
    }
}
