namespace src;

public class Student:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class StudentStore:Store<Student>
{
    // public List<Student> Students { get; set; }
    //
    // public void AddStudent(Student st)
    // {
    //     Students.Add(st);
    // }
    // public Student? GetStudentById(int id)
    // {
    //     return Students.FirstOrDefault(s => s.Id == id);
    // }
    // public List<Student>GetAllStudents()
    // {
    //     return Students;
    // }
    //
    // public void RemoveStudent(int id)
    // {
    //     if(GetStudentById(id) != null)
    //     {
    //         Students.Remove(GetStudentById(id));
    //         Console.WriteLine("Student Removed");
    //     }
    // }
}