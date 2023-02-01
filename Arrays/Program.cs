// See https://aka.ms/new-console-template for more information


// Declare and fixed size array
int[] grades;

// add values to fixed size array
//grades[0] = 1;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 48;
//grades[4] = 88;

 grades = new int[] { 1, 25, 38, 48, 88 };

for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter your grade :  ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print value and fixed size array

//Console.WriteLine("The grades you have entered are : ");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write(grades[i] + " ");
}

// Declare variable sized array

string[] studentNames = new string[] {"Audrey", "Drea", "ect..."};
// add values to variable sized array

for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write("Enter your name :  ");
    studentNames[i] = Console.ReadLine();
}
// Print value in variable sized array
Console.WriteLine("The names you have entered are : ");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write(studentNames[i] + " ");
}
