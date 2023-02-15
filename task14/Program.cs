// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = Random.Shared.Next(10,100);
Console.WriteLine(number);

int digitone = number / 10;
// Console.WriteLine(digitone);

int digittwo = number % 10;
// Console.WriteLine(digittwo);

if (digitone > digittwo)
{
    Console.WriteLine(digitone);
}
else
{
    Console.WriteLine(digittwo);
}