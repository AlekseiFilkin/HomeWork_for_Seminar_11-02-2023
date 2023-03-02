//Показать натуральные числа от 1 до N, N задано
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int firstNum = 1;

string ShowNumbers(int firstNum, int N)
{
    if (firstNum <= N) return $"{firstNum} " + ShowNumbers(firstNum+1, N);
    else return string.Empty;
}

Console.Write(ShowNumbers(firstNum, N));