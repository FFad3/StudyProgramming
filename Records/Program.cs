using System;

namespace Records
{
    class Program
    {
        public static void DisplayCourseName(Course course)
        {
            Console.WriteLine($"Name : {course.Name}");
        }
        static void Main(string[] args)
        {
            var course1 = new Course();
            course1.Name = "to jest kurs";
            course1.Author = "To jest author";

            DisplayCourseName(course1);

            var classsRommCourse = new CourseRecord(
                "Worki with c#",
                "gambit"
                );
            Console.ReadKey();
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }

    public record CourseRecord(string Name, string Author);
}
