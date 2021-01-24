using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Model
{
    public class Courses
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public Degree deg { get; set; }
    }
}
