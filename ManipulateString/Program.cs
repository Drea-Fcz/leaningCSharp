// See https://aka.ms/new-console-template for more information

string lastName = "Facquez";
string firstName = "Drea";
DateTime date = DateTime.Now;

// Print to String
Console.WriteLine($"My name is {firstName} {lastName}");
// Concatenation
Console.WriteLine("My name is " + firstName + " " + lastName);
// String Length
int length = firstName.Length;
Console.WriteLine("Your name is {0} letters long",length);

// Replace String Parts
string newName = firstName.Replace("D", "F");
Console.WriteLine($"the old name was {firstName}, the new one is {newName}")
;
// Append To Other String Variable
string fullName = firstName + " " + lastName;

// Slit String

string[] splitName = fullName.Split('a');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

// Compare String
 