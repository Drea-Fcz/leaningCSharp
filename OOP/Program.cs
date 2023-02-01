// See https://aka.ms/new-console-template for more information

// primitive datatype - int, char, bool string, double

// Object Oriented Programming - Creating your own datatype
// class - blueprint

// Single Responsibility Principal 

using ClassesAndObjects;

Person person = new();

Console.WriteLine("Enter First Name");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter your Age");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Salary");
double salary = Convert.ToInt32(Console.ReadLine());
person.SetSalary(salary);

Console.WriteLine("Enter your MiddleName");
string? middleName = Console.ReadLine();

Console.WriteLine(string.IsNullOrEmpty(middleName)
    ? $"Full Name is : {person.GetFullName()}"
    : $"Full Name is : {person.GetFullName(middleName)}");

// Console.WriteLine($"Age is : { person.Age }");
Console.WriteLine($"You are born in { DateUtil.YearOfBirth(person.Age) }");
Console.WriteLine($"Salary is : { person.GetSalary() }");

DateUtil.Age(1984);
;

