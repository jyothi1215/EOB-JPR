using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.Models
{
    public class EmployeeDetails
    {
         
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeSurName { get; set; }
        public string BloodGroup { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNo { get; set; }
        public string AlternatePhoneNo { get; set; }
        public string MailID { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public  int PermanentCountryID { get; set; }
        public int PermanentStateID { get; set; }
        public int PermanentCityID { get; set; }
        public int PermanentColonyID { get; set; }
        public string PermanentHouseNo { get; set; }
        public int TemporaryCountryID { get; set; }
        public int TemporaryStateID { get; set; }
        public int TemporaryCityID { get; set; }
        public int TemporaryColonyID { get; set; }
        public string TemporaryHouseNo { get; set; }
    }
}








