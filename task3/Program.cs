// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// 
// m = 2, n = 3 -> A(m,n) = 29

using System;
using static System.Console;

Clear();

WriteLine("Введите M и N через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int first = int.Parse(sizeS[0]);
int second = int.Parse(sizeS[1]);
int j = 0;
WriteLine($"A({first},{second}) = {Ackerman(first, second)}");

int Ackerman(int m, int n)
{
    if (m == 0)      // m = 0
    {
        return n + 1;
    }
    else if (n == 0) // m > 0, n = 0
    {
        return  Ackerman(m - 1, 1);      
    }
    return Ackerman(m - 1, Ackerman(m, n - 1)); // m > 0, n > 0
}