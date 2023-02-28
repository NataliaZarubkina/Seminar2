int Number1;
while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out Number1))
        break;
    Console.WriteLine("Ошибка ввода!");
}
int A(int Number1)
{
    while (Number1 > 999)
        Number1 = Number1 / 10;
    return Number1 % 10;
}
if (Number1 < 100)
    Console.WriteLine("Третьей цифры нет!");
else Console.WriteLine(A(Number1));