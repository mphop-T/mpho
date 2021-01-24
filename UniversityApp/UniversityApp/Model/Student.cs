using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Model
{
    public class Student
    {
        struct Forenames
        {
            public Forenames(string FirstName, string MiddleName)
            {
                this.FirstName = FirstName;
                this.MiddleName = MiddleName;
            }
            public string FirstName;
            public string MiddleName;
        }        
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DegreeID { get; set; }

    }
}
