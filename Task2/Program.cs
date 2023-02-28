Console.WriteLine("Введите число");
int Number1 = int.Parse(Console.ReadLine() ?? "");

int a1 = Number1 % 7;
int a2 = Number1 % 23;
if (a1 == 0 && a2 == 0)
{
    Console.WriteLine($"{Number1} -> кратно 7 и 23");
}
else Console.WriteLine($"{Number1} -> не кратно 7 и 23");