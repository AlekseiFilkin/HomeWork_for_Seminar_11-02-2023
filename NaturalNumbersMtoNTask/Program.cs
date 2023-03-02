//Показать натуральные числа от M до N, N и M заданы
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");

string ShowNumbers(int M, int N)
{
    if (M <= N) return $"{M} " + ShowNumbers(M + 1, N);
    else return String.Empty;
}

Console.Write(ShowNumbers(M, N));