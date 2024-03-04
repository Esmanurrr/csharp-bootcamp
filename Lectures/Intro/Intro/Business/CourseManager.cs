using Intro.Entities;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses = new Course[2];
    //constructor
    public CourseManager()
    {
        Course course1 = new();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET 8";
        course1.Price = 0;

        Course course2 = new();
        course2.Id = 1;
        course2.Name = "Java";
        course2.Description = "Java 17";
        course2.Price = 10;

        courses[0] = course1;
        courses[1] = course2;

    }

    public Course[] GetAll()
    {
        return courses;
    }
}
