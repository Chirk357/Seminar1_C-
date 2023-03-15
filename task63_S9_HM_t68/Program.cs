// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

uint M = 2;
uint N = 3;
Console.WriteLine(fAkkerman(M, N));

uint fAkkerman(uint m, uint n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return fAkkerman(m - 1, 1);
    else return fAkkerman(m - 1, fAkkerman(m, n - 1)); 
}