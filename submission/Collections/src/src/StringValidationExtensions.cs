using System.Text.RegularExpressions;

namespace src;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            return false;
        }
        
        string digitsOnlyPart = "";

        if (phoneNumber.StartsWith("+20"))
        {
            if (phoneNumber.Length != 13)
                return false;
            digitsOnlyPart = phoneNumber.Substring(3); 
        }
        else if (phoneNumber.StartsWith("0"))
        {
            if (phoneNumber.Length != 11) 
                return false;
            digitsOnlyPart = phoneNumber.Substring(1); 
        }
        else
        {
            return false; 
        }

        foreach (char c in digitsOnlyPart)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        string operatorCode = digitsOnlyPart.Substring(0, 2);
        if (operatorCode != "10" && operatorCode != "11" && operatorCode != "12" && operatorCode != "15")
        {
            return false;
        }
        return true;
    }
    public static bool IsValidEgyptianNationalId(this string nationalId)
    {
        if(nationalId.Length != 14)
            return false;
        if (!nationalId.StartsWith("2")  && !nationalId.StartsWith("3"))
            return false;
        return true;
    }
    
    private static readonly Regex phoneRegex = new Regex(@"^(\+20|0)(10|11|12|15)\d{8}$",  RegexOptions.Compiled);
    private static readonly Regex NationalIdRegex = new Regex(@"^[23]\d{13}$", RegexOptions.Compiled);

    public static bool IsValidEgyptianPhoneByRegex(this string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
            return false;
        
        return phoneRegex.IsMatch(phoneNumber);
    }

    public static bool IsValidEgyptianNationalIdByRegex(this string nationalId)
    {
        if (string.IsNullOrEmpty(nationalId))
            return false;
        return NationalIdRegex.IsMatch(nationalId);
    }
    
    
    
}