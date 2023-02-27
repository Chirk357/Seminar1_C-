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

int SumToN(int N)
{
    int sum = 0;
    int newN = 0;
    
    while(N > 0)
    {
        newN = N % 10;
        N = N / 10;
        
        sum = sum + newN;
    
    }
    return sum;
}


int value = ReadNumber("введите число");
int sum = SumToN(value);
Console.WriteLine(sum);