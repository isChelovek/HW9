// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.
// 
// M = 1; N = 5. ->120
// 
// M = 4; N = 6. -> 120

using System;
using static System.Console;

Clear();

WriteLine("Введите M и N через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
 
WriteLine(multiplication (m, n));

int multiplication(int first, int second)
{
    if (first != second)
    {
        return  second * multiplication(first, second - 1);      
    }
    return first;
}