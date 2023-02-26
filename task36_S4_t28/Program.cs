// Задача 28: 
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int ReadNumber(string message) 
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
   
}


int Multiply(int N)
{
    int i = 1;
    int res = 1;

    for(i = 1; i <= N; i++)
    {
        res = res * i;
    }
    return res;
}

int value = ReadNumber("Введите число");
int result = Multiply(value);
Console.WriteLine(result);