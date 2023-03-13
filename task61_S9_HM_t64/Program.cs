// Задача 64: 
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 5;
PrintNTo1(number);

void PrintNTo1(int n)
{
    if (n < 1) return;
    PrintNTo1(n - 1) + n;
    Console.Write($"{n} ");
}