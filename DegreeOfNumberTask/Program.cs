//Написать программу возведения числа А в целую стень B

Console.Write("Введите число, которе нужно возвести в степень: ");
int num = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите степень: ");
int deg = int.Parse(Console.ReadLine() ?? "");

int Exponentiation(int num, int deg)
{
    if (deg != 0) return Exponentiation(num, deg - 1) * num;
        else return 1;
}
Console.WriteLine($"{num}^{deg} = {Exponentiation(num, deg)}");