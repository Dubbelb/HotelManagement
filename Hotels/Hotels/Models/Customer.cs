using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotels.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string DateOfbirth { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }

        public string PassPortNumber { get; set; }
        public Country PassportIssueCountry { get; set; }
    }
}
