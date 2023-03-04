/*Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем*/

Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите длину последовательности чисел: ");
int N = int.Parse(Console.ReadLine() ?? "");
int FirstNumbers(int numA, int numB, int anyNum)
{
    int numC = 0;
    if (anyNum <= 1)
    {
        numC = numA + numB;
    }
    if (anyNum + 1 > 1)
    {
        numC = numA + numB;
        numA = numB;
        numB = numC;
        anyNum = anyNum - 1;
        Console.Write($"{numC} ");
        FirstNumbers(numA, numB, anyNum);
    }
    return numC;
}

Console.Write($"{A} {B} ");
FirstNumbers(A, B, N);