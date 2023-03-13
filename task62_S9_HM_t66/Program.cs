// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int number = 15;
int start = 1;
Console.WriteLine(SumOfNumbers(start, number));

int SumOfNumbers(int m, int n)
{
    if (m > n) return 0;
    if (m < n) return n + SumOfNumbers(m, n-1);
    return n;
}
