// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите число N: ");
int maxValue = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Последовательные числа от {maxValue} до 1 --> {Recurs(maxValue)}");

string Recurs(int maxValue)
{
    if (maxValue == 1) return maxValue.ToString();
    return (maxValue + " " + Recurs(maxValue - 1));
}