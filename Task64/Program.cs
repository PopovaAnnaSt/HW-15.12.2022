// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(n));

string PrintNumbers(int end)
{
    if (end == 1)
        return "1";
    return (end.ToString()+ ' ' + PrintNumbers(end - 1) );
}
