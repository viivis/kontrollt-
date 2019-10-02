using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public class Teacher
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsFullTime { get; set; }

        public List<Course> courses { get; set; } = new List<Course>();

    

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        public Teacher (bool FullTime)
        {
            IsFullTime = FullTime;
        }
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

    }
}
