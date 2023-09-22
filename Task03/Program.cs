//На вход принимает число
//На выходе числа от -n до n

int n, otrn;
Console.Write("Введите целое число: ");
while(!int.TryParse(Console.ReadLine(), out n))
Console.Write("Данные не корректны, повторите ввод: ");
otrn = -n;
while (otrn <= n)
{
    Console.Write($"{otrn++} ");//Console.Write($"{otrn} ");
    //otrn ++;
}