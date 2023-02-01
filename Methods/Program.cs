// See https://aka.ms/new-console-template for more information

// Prototype _ Defines the function (type, name and parameters)

// Definition - Has the code. It contains the code block function

// Function call - Make the function executes
// DRY - Don't Repeat Yourself !!
// YAGNI - You Aren't Going To Need It !



// Void functions - Completes a task and move

//void PrintName()
//{
//    Console.WriteLine("Drea =)");
//}

void Addition(int n1, int n2)
{
    Console.WriteLine($"Sum of {n1} and {n2} is {n1 + n2}");

}

int LargestNumber(int n1, int n2, int n3)
{
    int largest = n1;

    if (largest < n2)
    {
        largest = n2;
    }

    if (largest < n3)
    {
        largest = n3;
    }

    return largest;
}

//// PrintName();

//Console.WriteLine("Enter number 1: ");
//int number1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter number 2: ");
//int number2 = Convert.ToInt32(Console.ReadLine());

//Addition(number1, number2);


// Value Returning Functions -  Completes a task, returns a result


Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);


Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int res = LargestNumber(number1, number2, number3);
Console.WriteLine($"the result is {res}");
