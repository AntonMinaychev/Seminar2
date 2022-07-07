Console.WriteLine("Insert number of the week's day (1-7)");
int a = int.Parse(Console.ReadLine());

if (a == 7 ^ a == 6)
{
Console.WriteLine("Get some rest!");
}
else
Console.WriteLine("Go to the work!");