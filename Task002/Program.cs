Console.WriteLine("Введите номер дня недели");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 == 1)
{
    Console.WriteLine($"{number1} -> понедельник");
}
else if (number1 == 2)
{
    Console.WriteLine($"{number1} -> Вторник");
}
else if (number1 == 3)
{
    Console.WriteLine($"{number1} -> Среда");
}
else if (number1 == 4)
{
    Console.WriteLine($"{number1} -> Четверг");
}
else if (number1 == 5)
{
    Console.WriteLine($"{number1} -> Пятница");
}
else if (number1 == 6)
{
    Console.WriteLine($"{number1} -> Суббота");
}
else if (number1 == 7)
{
    Console.WriteLine($"{number1} -> Воскресенье");
}
else Console.WriteLine("ошибка ввода, введите число от 1 до 7");
