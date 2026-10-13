namespace src;

public class Course
{
    public Course(int id, string title, decimal price)
    {
        Id = id;
        Title = title;
        Price = price;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    
}

public class CourseStore
{
    public List<Course> Courses { get; set; }

    public void AddCourse(Course st)
    {
        Courses.Add(st);
    }
    public Course? GetCourseById(int id)
        => Courses.FirstOrDefault(s => s.Id == id);
    public List<Course>GetAllCourses()
        => Courses;

    public void RemoveCourse(int id)
    {
        if(GetCourseById(id) != null)
        {
            Courses.Remove(GetCourseById(id));
            Console.WriteLine("Course Removed");
        }
    }
}