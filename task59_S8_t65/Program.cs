// Задача 65: 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


void NaturalValues(uint n, uint m)
{
    if (n > m) Console.WriteLine("Число n не может быть больше m");
    else if (m > n) NaturalValues(n, m - 1);
    else Console.Write(m + " ");
}

NaturalValues(5, 10);
Console.WriteLine();
NaturalValues(6, 3);