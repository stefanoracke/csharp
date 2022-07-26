// See https://aka.ms/new-console-template for more information

Console.WriteLine("Write your name: ");
string nombre = Console.ReadLine();



//Edad

Console.WriteLine("Write your age: ");
string age = Console.ReadLine();

int num_age = Int32.Parse(age);

//City
Console.WriteLine("Where you live?: ");
string city = Console.ReadLine();


Console.WriteLine("Hello " + nombre + ", your age is "+ age + " you live in "+ city);