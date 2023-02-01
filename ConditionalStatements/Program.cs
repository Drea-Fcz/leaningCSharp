// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

// If Statements ( ==, <, >, >=, <=, !=)
if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more apples");
}
else if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more oranges");

}
else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("You have the same number of oranges & apples");

}
else
{
    Console.WriteLine("You need to open your bag to check !");

}

// Switch Statements
Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

switch(grade)
{
    case int n when n >=  0 && n <= 59:
        Console.WriteLine("You failed");
        break;

    case int n when n >= 60 &&  n <= 100:
        Console.WriteLine("You Passed");
        break;
    case 101:
        Console.WriteLine("Single case Example");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}



// Ternary Operator
var message = numberOfApples > numberOfOranges ? "You have more apples" : "You have more oranges";