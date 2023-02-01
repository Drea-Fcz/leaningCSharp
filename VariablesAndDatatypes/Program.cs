// See https://aka.ms/new-console-template for more information
/*
     try - a try lok attempts an operation
     catch - catch any fatal error or exception
     final - whether the try or the catch was successful, do this
     throw - end the program execution with error
 */

Console.WriteLine("Enter first number: ");
int? num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number : ");
int? num2 = Convert.ToInt32(Console.ReadLine());

try
{
    int? quotient = num1 / num2;
    Console.WriteLine("Result is: " + quotient);

}
catch(DivideByZeroException ex)
{
    Console.WriteLine($"Illegal Operation({ex.Message})");
}
catch (Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("this is the end of the program");
}

// int quotient = num1 / num2;



