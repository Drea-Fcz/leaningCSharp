// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// For Loop (Counter Controlled)

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"I'm in the loop {i + 1}");
//}

//Console.WriteLine();
//Console.WriteLine("For Loop is finished ");

// While Loop  (Condition Controlled - Pre Check)
//int n = 0;
//while (n < 5)
//{
//    Console.WriteLine("Input a number: ");
//    // n = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine($"You entered {n}");

//    n += 1;
//}

//Console.WriteLine("While Loop is finished ");

// Do.. While Loop

int n = 0;

do
{
    Console.WriteLine("Input a number: ");
    // n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The value is {n}");

    n += 1;

} while (n < 5);

// Foreach - Honourable Mention
var collection = "element 2"; // I don't know how to do an array i C#

foreach (var item in collection)
{
    Console.WriteLine(item);
}

