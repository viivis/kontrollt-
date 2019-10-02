using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Course
    {
      

        public string Name { get; set; }

        public double Duration { get; set; }

        public Teacher teacher { get; set; }

        public Course (string name, double duration)
        {
            Name = name;
            Duration = duration;
        }

        
    }
}
