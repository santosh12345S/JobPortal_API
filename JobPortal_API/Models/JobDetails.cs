using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal_API.Models
{
    public class JobDetails
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string CompanyName { get; set; }
        public string Eligibility { get; set; }
        public string Qualification { get; set; }
        public float Salary { get; set; }
        public string JobLocation { get; set; }
       

    }
}