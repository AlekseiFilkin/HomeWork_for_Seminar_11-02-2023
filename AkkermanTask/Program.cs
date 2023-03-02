//Написать программу вычисления функции Аккермана

Console.Write("Введите первое число функции: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число функции: ");
int n = int.Parse(Console.ReadLine() ?? "");
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return Akkerman(m, n);
}
Console.WriteLine($"Значение функции Аккермана {Akkerman(m, n)}");