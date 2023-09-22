//При вводе числа вывести соответствующий ему день недели

int n;
Enter:
Console.Write("Введите целое число: ");
while(!int.TryParse(Console.ReadLine(), out n))
Console.Write("Данные не корректны, повторите ввод: ");
if (n == 1)
{
    Console.Write($"{n} -> Пн");
}
else if (n == 2)
{
    Console.Write($"{n} -> Вт");
}
else if (n == 3)
{
    Console.Write($"{n} -> Ср");
}
else if (n == 4)
{
    Console.Write($"{n} -> Чт");
}
else if (n == 5)
{
    Console.Write($"{n} -> Пт");
}
else if (n == 6)
{
    Console.Write($"{n} -> Сб");
}
else if (n == 7)
{
    Console.Write($"{n} -> Вс");
}
else
{
    Console.WriteLine("Такого дня нет");
    goto Enter;
}
