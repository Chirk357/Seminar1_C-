// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
     
}

int SumToN(int N);
{
   for(int i = 0; N =! 0; i++)
    {
    N = N % 10;
    int sum = sum + N;

    return sum;
    }
}

int value = ReadNumber("введите число");
int sum = SumToN(value);