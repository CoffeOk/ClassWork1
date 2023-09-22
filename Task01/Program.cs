int x, y;
Console.Write("Введите число x: ");
while (!int.TryParse(Console.ReadLine(), out x))
    Console.WriteLine("Введите целое число");
Console.Write("Введите число y: ");
while (!int.TryParse(Console.ReadLine(), out y))
    Console.WriteLine("Введите целое число");
if (y/x == x)
{
    Console.WriteLine($"x = {x}, y = {y} -> Да");
}
else
{
    Console.WriteLine($"x = {x}, y = {y} -> Нет");
}                         