﻿// See https://aka.ms/new-console-template for more information


// Basic Assignment Operator
int num = 5;


// Arithmetic Operators
int num1 = 11;
int num2 = 12;

Console.WriteLine($"Addition: {num1 + num2 }");
Console.WriteLine($"Subtraction: {num1 - num2 }");
Console.WriteLine($"Multiplication: {num1 * num2 }");
Console.WriteLine($"Division: {num1 / num2 }");
Console.WriteLine($"Modulus: {num1 % num2 }");

// 5/2 = 2 times, remainder 1    => modulus ===> 5%2 remainder 1

num1 = num1 + 4;
Console.WriteLine($"New Value of num1 : {num1}");
Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");


// Coumpound Assignment Operators

num1 += 4; // num1 = num1 + 4 accumulator
Console.WriteLine($"New Value with + : {num1}");
num1 -= 4; // num1 = num1 - 4
Console.WriteLine($"New Value with - : {num1}");
num1 *= 4; // num1 = num1 * 4
Console.WriteLine($"New Value with * : {num1}");
num1 /= 4; // num1 = num1 / 4
Console.WriteLine($"New Value with / : {num1}");
num1 %= 4; // num1 = num1 % 4
Console.WriteLine($"New Value with % : {num1}");