// Задача 24: 
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int ReadNumber(string message) // 1й метод отвечает за ввод числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
   
}

int findSum(int A) // 2й метод отвечает за нахождение суммы
{
    int sum = 0;
    int i = 1;

    for(i = 1; i <= A; i++)
    {
        sum = sum + i;        
    }
    return sum;
}

int value = ReadNumber("Введите число А");
int sumOf = findSum(value);
Console.WriteLine(sumOf);