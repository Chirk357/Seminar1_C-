// Задача 19: 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());

int LastDigit;
int LastDigit2;
int LastDigit3;
int LastDigit4;

int N2;
int N3;
int N4;
int N5;

if (N > 9999 && N < 100000)
{
    LastDigit = N / 10;
    N2 = N % 10;

    LastDigit2 = N2 / 10;
    N3 = N2 % 10;

    LastDigit3 = N3 / 10;
    N4 = N3 % 10;

    LastDigit4 = N4 / 10;
    N5 = N4 % 10;
}

Console.WriteLine("не полиндром");

if(LastDigit == N5)
{
    if(LastDigit2 == LastDigit4)
    {
        Console.WriteLine("полиндром");
    }
}
else
{
    Console.WriteLine("не полиндром");
}