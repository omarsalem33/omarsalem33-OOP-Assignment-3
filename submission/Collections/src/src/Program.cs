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

        Console.WriteLine($"Adding student {std1.Name} with ID {std1.Id}");
        Console.WriteLine($"Adding student {std2.Name} with ID {std2.Id}");

        var store = new Store<Student>();
        store.Add(std1);
        store.Add(std2); 

        var allStudents = store.GetAll();
        foreach (var student in allStudents)
        {
            Console.WriteLine($"- {student.Name} (ID: {student.Id})");
        }
        
    }
}