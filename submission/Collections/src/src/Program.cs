namespace src;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("01012345678".IsValidEgyptianPhone());        
        // Console.WriteLine("01012345678".IsValidEgyptianPhoneByRegex());
        // Console.WriteLine("+201512345678".IsValidEgyptianPhoneByRegex());
        // Console.WriteLine("01312345678".IsValidEgyptianPhone());
        // Console.WriteLine("0101234567".IsValidEgyptianPhoneByRegex());
        // Console.WriteLine("0101234567a".IsValidEgyptianPhoneByRegex());
        // Console.WriteLine("29901011234567".IsValidEgyptianNationalIdByRegex());
        // Console.WriteLine("19901011234567".IsValidEgyptianNationalIdByRegex());
        // Console.WriteLine("2990101123456".IsValidEgyptianNationalId());


        var std1 = new Student(id: 1, name: "Omar");
        var std2 = new Student(id: 2, name: "Ahmed");
        var std3 = new Student(id: 3, name: "Hala");
        var std4 = new Student(id: 4, name: "Sara");
        var std5 = new Student(id: 5, name: "Ali");
        
        var course1 =  new Course(101,"Programming",500m);
        var course2 =  new Course(102,"IT",250m);
        var course3 =  new Course(103,"Network",300m);
        
        var storeStudent= new Store<Student>();
        storeStudent.Add(std1);
        storeStudent.Add(std2);
        storeStudent.Add(std3);
        storeStudent.Add(std4);
        storeStudent.Add(std5);
        
        var storeCourse = new Store<Course>();
        storeCourse.Add(course1);
        storeCourse.Add(course2);
        storeCourse.Add(course3);
        //
        // try
        // {
        //     storeStudent.Add(std1);
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e);
        //     throw;
        // }

        var page2Student = storeStudent.GetAll().Page(2,2);
        foreach (var item in page2Student)
            Console.WriteLine($"Student: {item.Name} (ID: {item.Id})");

        var foundCourse = storeCourse.GetAll().FindById(101);
        if(foundCourse != null)
            Console.WriteLine($"Found Course: {foundCourse.Title} (ID: {foundCourse.Id})");
    }
}