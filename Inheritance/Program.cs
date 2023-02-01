// See https://aka.ms/new-console-template for more information

using Ineheritance;

Console.WriteLine("Enter Lenght : ");
var length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width : ");
var width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height : ");
var height = Convert.ToInt32(Console.ReadLine());

var cube = new Cube(width, height, length);
var triangle = new Triangle() {Hypotenuse = 10, Height = height, Length = length};
var triangle1 = new Triangle(10);
var triangle2 = new Triangle(10, height, length);
var rectangle = new Rectangle() {Width = width, Length = length};

/*cube.Length = length;
cube.Height = height;
cube.Width = width;*/

/*triangle.Length = length;
triangle.Height = height;*/

/*rectangle.Length = length;
rectangle.Width = width;*/

Console.WriteLine($"Cube Area is : {cube.GetArea()}");
Console.WriteLine($"Cube Volume is : {cube.GetVolume()}");
Console.WriteLine($"Triangle Area is : {triangle.GetArea()}");
Console.WriteLine($"Rectangle Area is : {rectangle.GetArea()}");