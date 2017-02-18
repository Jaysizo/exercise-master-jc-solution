using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi1.Models.BusinessObjects
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
    }
}