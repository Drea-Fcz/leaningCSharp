namespace ClassesAndObjects;

public class Person
{
    // Properties when public 
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int Age { get; set; }

    // Fields when private using _
    private double _salary { get; set; }

    public void SetSalary(double amount)
    {
        _salary = amount;
    }

    public double GetSalary()
    {
        return _salary;
    }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}" ;
    }
    public string GetFullName(string? middleName)
    {
        return $"{FirstName} {middleName} {LastName}" ;
    }

    public int GetYearOfBirth()
    {
        var year = DateTime.Now.Year - Age;
        return year;
    }
}