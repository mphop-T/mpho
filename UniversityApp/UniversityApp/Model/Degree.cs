using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Model
{
    public class Degree
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public Lecturer lecture { get; set; }
        public Courses course { get; set; }
    }
}
