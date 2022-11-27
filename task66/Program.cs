// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");

SumCount(m, n);

void SumCount(int one, int two)
{
    int sum = 0;
    while (one <= two)
    {
        sum = sum + one;
        one++;
    }
    Console.WriteLine("Сумма натуральных элементов равна  " + "{0,0:F0}", sum);
}