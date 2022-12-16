// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using System;
using static System.Console;

Clear();
Write("Введите неотрицательное число M: ");
int m = int.Parse(ReadLine());
Write("Введите неотрицательное число N: ");
int n = int.Parse(ReadLine());

if (m < 0 || n < 0){
    WriteLine("Числа введены неверно");
    return;
}

WriteLine($"Результат -> {FunctionAckerman(m, n)}");

int FunctionAckerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return FunctionAckerman(m - 1, 1);
    return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
}
