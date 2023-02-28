int Number1;

while (true)
{
    Console.Write("Введите трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out Number1))
        break;
    Console.WriteLine("Ошибка ввода!");
}

if (Number1 < 100 || Number1 > 999)
{
    Console.WriteLine("Число не трехзначное!");
    return;
}
int A = (Number1 / 10) % 10;
Console.WriteLine($"{Number1} ->{A}");

