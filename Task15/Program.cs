Console.Write("Введите целое число от 1 до 7: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");
if ((userNumber1 > 7) || (userNumber1 < 1))
    Console.WriteLine("Неверное число");
else if ((userNumber1 == 6) || (userNumber1 == 7))
    Console.WriteLine($"{userNumber1} - Выходной день");
    else Console.WriteLine($"{userNumber1} - Рабочий день");
