Console.WriteLine("Insert number");
int a = int.Parse(Console.ReadLine());
int third;

if (a <= 99)
{
Console.WriteLine("There is no third digit");
System.Environment.Exit(0);                             // Выходим из программы
}

third = int.Parse(a.ToString()[2].ToString()); // Преобразует а в строку-массив, возвращает 2 элемент (т.к. отсчет в массиве с 0)

Console.WriteLine("Third digit is ");
Console.WriteLine(third);