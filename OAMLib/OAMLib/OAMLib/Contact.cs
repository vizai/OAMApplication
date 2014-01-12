using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dlabs.OAMLib
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int DesignationID { get; set; }
        public string Profile { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact()
        {
        }

        public int CreateContact()
        {
            return 0;
        }
        public int DeleteContact()
        {
            return 0;
        }

        public int UpdateContact()
        {
            return 0;
        }
        public static List<Contact> GetAllContacts()
        {
            return null;
        }

        public static List<Contact> GetContactsByDesignationID(int designationID)
        {
            return null;
        }
        public static List<Contact> GetContactsByDesignation(string designation)
        {
            return null;
        }
        public static Contact GetContactsByID(int ApplicationID)
        {
            return null;
        }
    }
}
