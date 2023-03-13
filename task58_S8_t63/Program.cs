// Задача 63 РЕКУРСИЯ
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// 1й метод

int number = 5;
PrintToN(number);

void PrintToN(int n)
{
    if (n < 1) return;
    PrintToN(n-1);
    Console.Write($"{n} ");
}



// 2й метод в группе
// void NaturalValue(uint n)
// {
//     if (n > 1)
//     {
//         NaturalValue(n - 1);
//     }
//     Console.Write(n + " ");
// }
// NaturalValue(9);
// Console.WriteLine();
// NaturalValue(11);





