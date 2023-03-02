//Найти сумму элементов от M до N, N и M заданы
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");

int SumElements(int M, int N)
{
    if (M < N) return M + SumElements(M + 1, N);
    else return 0;
}

Console.Write($"Суммф всех элементов от {M} до {N} равна {SumElements(M, N)}");