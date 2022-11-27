// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.

// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"


Console.WriteLine("Введите значение N:");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("");

CountRes(N, 1);

void CountRes(int random, int oneArgyment)
{
    int i = random;
    oneArgyment = 1;

    while (i >= oneArgyment)
    {
        if (i % 2 == 0)
        {
            Console.Write(i);
            Console.Write(", ");
        }
        i--;
    }
}
