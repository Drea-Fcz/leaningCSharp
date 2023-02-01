// See https://aka.ms/new-console-template for more information

// Declaration of list 
List<string> names = new List<string>();
string? name = string.Empty;

// Add values to list
// names.Add("Drea");
//names.Remove("Drea"); // mapping list it's more dynamic 

// Print list value
Console.WriteLine("Enter Names: ");
// (name != "-1")
while (!name.Equals("-1"))
{
    Console.WriteLine();
    Console.WriteLine("Enter Name: ");

    name = Console.ReadLine();

    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.Write($" {name} was added successfully");

    }
}

// Print values in list

//for (int i = 0; i < names.Count; i++)
//{
//    Console.Write(names[i] + " ");
//}

foreach (string item in names)
{
       Console.Write(item + " ");

}