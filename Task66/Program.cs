// Задача 66: Задайте значения M и N. Напишите программу, которая  
// найдёт сумму натуральных элементов в промежутке от M до N.

using System;
using static System.Console;

Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine());
Write("Введите число N: ");
int n = int.Parse(ReadLine());

WriteLine($"Сумма равна {SumElements(m, n)}");

int SumElements(int m, int n)
{
    if (m > n)
        return 0;
    return (m + SumElements(m + 1, n));
}