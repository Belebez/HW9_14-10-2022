// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Натуральное число от А({m}, {n}) --> {AckermannFunction(m, n)}");

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckermannFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else
        return n + 1;
}