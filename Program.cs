using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    public enum Level : byte { 
        Beginner = 1,
        Intermidiate = 2,
        Adavanced = 3
    }
    class Program
    {
        static  void Main(string[] args)
        {
            var course = new Course();
            // course.Level = CourseLevel.Beginner;
            course.Level = Level.Beginner;
            //foreach (var c in new PlutoDbContext().GetCourses()) Console.WriteLine(c.Title);
        }
    }
}
