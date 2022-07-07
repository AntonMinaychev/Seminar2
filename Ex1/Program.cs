Console.WriteLine("Insert three-digit number");
int a = int.Parse(Console.ReadLine());
int number;
float b;

number = a%100;
b = number/10;

Console.WriteLine("The second digit in the number is: ");
Console.WriteLine(Math.Truncate(b));
