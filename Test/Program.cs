using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //teacher
            Console.WriteLine("Please enter teacher's first name!");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter teacher's last name!");
            string lastName = Console.ReadLine();

            Teacher teacher = new Teacher(firstName, lastName);

            Console.WriteLine("Teacher: " + teacher);


            Console.WriteLine("Does teacher work full time? (Y/N)");
            if (Console.ReadLine() == "Y")
            {
                Console.WriteLine("Works full time");

            }
            else if (Console.ReadLine() == "N")
            {
                Console.WriteLine("Doesn't work full time");
            }

           /* Console.WriteLine("Enter a course");
            string courseinput = Console.ReadLine();
        
            Console.WriteLine("Enter a duration");
            double durationInput = double.Parse(Console.ReadLine());
            Course course = new Course(courseinput, durationInput);*/
            Course cours2 = new Course("bioloogia", 8);
            Course cours3 = new Course("matemaatika", 2);
            Course cours4 = new Course("muusika", 4);

            
            teacher.AddCourse(cours2);
            teacher.AddCourse(cours3);
            teacher.AddCourse(cours4);


          

            Console.WriteLine("Teacher: " + firstName + " " + lastName + " "+ "Courses: " + cours2.Name + " " + cours3.Name + " "  + cours4.Name);
               

          //  Console.WriteLine("Teacher: " + firstName + " " + lastName + " courses: " + courseinput + " duration: " + durationInput);
        }







    }
}

