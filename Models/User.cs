using RemoteValidation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidation.Models
{
    public class User
    {
        [RemoteClientServer("IsUserAvailable", "Student", ErrorMessage = "User already exist.")]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public string AddressLine { get; set; }
        public string MobileNo { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }

        //  [Remote("IsUserNameAvailable", "Student", ErrorMessage = "LoginId already in use.")]
        [RemoteClientServer("IsUserNameAvailable", "Student", ErrorMessage = "LoginId already in use.")]
        public string LoginId { get; set; }
    }
}