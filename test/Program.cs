// Задача 19: 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число");
int Num = Convert.ToInt32(Console.ReadLine());-

if(Num > 9999 && Num < 100000)
{
    int LastDigit = Num % 10;
    int Num2 = Num / 10;

    int LastDigit2 = Num2 % 10;
    int Num3 = Num2 / 10;

    int LastDigit3 = Num3 % 10;
    int Num4 = Num3 / 10;

    int LastDigit4 = Num4 % 10;
    int Num5 = Num4 / 10;

    if(LastDigit == Num5)
    {
        if(LastDigit2 == LastDigit4)
        {
            Console.WriteLine("Полиндром");
        }
        else
        {
            Console.WriteLine("не полиндром");
        }
    }
    else
    {
        Console.WriteLine("не полиндром");
    }
}
Console.WriteLine("число не пятизначное");







// Console.WriteLine("Введите пятизначное число");
// int Num = Convert.ToInt32(Console.ReadLine());


// int LastDigit = Num % 10;
// int Num2 = Num / 10;

// int LastDigit2 = Num2 % 10;
// int Num3 = Num2 / 10;

// int LastDigit3 = Num3 % 10;
// int Num4 = Num3 / 10;

// int LastDigit4 = Num4 % 10;
// int Num5 = Num4 / 10;

// if(LastDigit == Num5)
// {
//     if(LastDigit2 == LastDigit4)
//     {
//         Console.WriteLine("Полиндром");
//     }
//     else
//     {
//         Console.WriteLine("error");
//     }
// }
// else
// {
//     Console.WriteLine("error");
// }