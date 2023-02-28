Console.WriteLine("Введите число");
int Number1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число");
int Number2 = int.Parse(Console.ReadLine() ?? "");

int a1 = Number1 % Number2;
if (a1 == 0)
{
    Console.WriteLine($"{Number1}, {Number2} -> кратно");
}
else Console.WriteLine($"{Number1}, {Number2} -> не кратно, остаток {a1}");