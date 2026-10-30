namespace src;

public class Student:IHasId
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public Student(int id, string name):base()
    {
        Id = id;
        Name = name;
    }
}
