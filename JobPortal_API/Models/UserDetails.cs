using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal_API.Models
{
    public class UserDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }
        public DateTime AppliedDate { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public  int Experience { get; set; }
        public HttpFileCollection Resume { get; set; }
    }
}