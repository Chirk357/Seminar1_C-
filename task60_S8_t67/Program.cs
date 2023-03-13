// Задача 67: 
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// 1й метод
int number = 453;
Console.WriteLine(SumOfDigits(number));

int SumOfDigits(int newNumber)
{
    if (number == 0) return 0;
    return newNumber % 10 + SumOfDigits(newNumber / 10);
}

// 2й метод
// В группе
// int sum = 0;
// void SumOfNumbers(int n)
// {
//     if (n / 10 > 0)
//     {
//         SumOfNumbers(n / 10);
//     }
//     sum += n % 10;
// }

// SumOfNumbers(453);
// System.Console.WriteLine(sum);