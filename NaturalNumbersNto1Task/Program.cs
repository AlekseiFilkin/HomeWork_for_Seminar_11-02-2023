//Показать натуральные числа от N до 1, N задано
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int lastNum = 1;

string ShowNumbers(int N, int lastNum)
{
    if (N >= lastNum) return $"{N} " + ShowNumbers(N-1, lastNum);
    else return string.Empty;
}

Console.Write(ShowNumbers(N, lastNum));