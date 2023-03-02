//Найти сумму цифр числа

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");
int SumDigits(int num)
{
    if (num != 0)
    {
        return num % 10 + SumDigits(num / 10);
    }
    else
    {
        return 0;
    }
}
Console.WriteLine($"Сумма цифр числа {num} равна {SumDigits(num)}");