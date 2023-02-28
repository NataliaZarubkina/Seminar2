Console.WriteLine("Введите число");
int Number1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число");
int Number2 = int.Parse(Console.ReadLine() ?? "");

if ((Number1 == Number2 * Number2) || (Number2 == Number1 * Number1))
{
    Console.WriteLine($"да");
}
else Console.WriteLine($"нет");