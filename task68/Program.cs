// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число для функции Аккермана: ");
int oneNum = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число для функции Аккермана: ");
int twoNum = int.Parse(Console.ReadLine() ?? "0");

PrintFunction(oneNum, twoNum);

int FunctionAkkerman(int one, int two)
{
    if (one == 0)
        return two + 1;
    else if ((one != 0) && (two == 0))
        return FunctionAkkerman(one - 1, 1);
    else
        return FunctionAkkerman(one - 1, FunctionAkkerman(one, two - 1));
}

void PrintFunction(int oneNum, int twoNum)
{
    Console.WriteLine("Результат вычисления функции Аккермана:  " + FunctionAkkerman(oneNum, twoNum));
}
