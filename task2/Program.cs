// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int max = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Сумма элементов в промежутке от {min} до {max} --> {SumRecurs(min, max)}");

int SumRecurs(int min, int max)
{
    if (min == max) return max;
    return (min + SumRecurs(min + 1, max));
}