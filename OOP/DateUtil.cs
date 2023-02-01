namespace ClassesAndObjects;

internal class DateUtil
{
    public static int YearOfBirth(int age)
    {
        return DateTime.Now.Year - age;
    }
    
    public static int YearOfBirth(DateTime dateOfBirth)
    {
        return  dateOfBirth.Year;
    }
    
    public static int Age(int dateOfBirth)
    {
        return DateTime.Now.Year - dateOfBirth;
    }
}