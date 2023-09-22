// На входе одно трёхзначное число
// На выходе - последняя цифра числа

int x, y;
Control:
Console.Write ("Введите целое число: ");
while(!int.TryParse(Console.ReadLine(), out x))
Console.Write("Данные не корректны, повторите ввод: ");
if (x < 1000)
{
    y = x % 10;
    Console.Write($"{x} -> {y}");
}
else
{
    Console.WriteLine("Введите число < 1000");
    goto Control;
}