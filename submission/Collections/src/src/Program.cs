namespace src;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("01012345678".IsValidEgyptianPhone());        
        Console.WriteLine("01012345678".IsValidEgyptianPhoneByRegex());
        Console.WriteLine("+201512345678".IsValidEgyptianPhoneByRegex());
        Console.WriteLine("01312345678".IsValidEgyptianPhone());
        Console.WriteLine("0101234567".IsValidEgyptianPhoneByRegex());
        Console.WriteLine("0101234567a".IsValidEgyptianPhoneByRegex());
        Console.WriteLine("29901011234567".IsValidEgyptianNationalIdByRegex());
        Console.WriteLine("19901011234567".IsValidEgyptianNationalIdByRegex());
        Console.WriteLine("2990101123456".IsValidEgyptianNationalId());
    }
}