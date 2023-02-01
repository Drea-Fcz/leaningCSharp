// See https://aka.ms/new-console-template for more information

// Declare Variable

/*
 Data Types
string - Words/numbers
integer - whole numbers | double/float - decimals
char - One Character ('A', '7, '%') 
 */

//string fullName = "Drea";  // camelCase better for variables 
//string HelloWorld; // PascalCase
//char a = 'A';

// Allow user input and store in variable
//Console.WriteLine("Enter your full Name");
//fullName = Console.ReadLine();

// Print contents of variable/user's input
//Console.Write("Nice to meet you ");
//Console.WriteLine(fullName);




// Variable Declaration and Types
// building default string value it's equal to string name = ""
string? fullName = string.Empty;
int? age = 0;
double? salary = 0.0;
// float salary = 0.0f (syntax)
// decimal salary = 0.0M (syntax)
char? gender = char.MinValue;
bool working = false;

Console.Write("Please enter your name: ");
fullName = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Please enter your working status (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

if (working)
{
    Console.WriteLine("Your name is: " + fullName); // concatenation
    Console.WriteLine("Your age is: {0}", age);     // arguments
    Console.WriteLine($"Your gender is: {gender}"); // interpolation
    Console.WriteLine($"Your are employed: {working}"); // interpolation
} else
{
    Console.WriteLine("I don't give a shit");
}


// error section
// explain how to debug