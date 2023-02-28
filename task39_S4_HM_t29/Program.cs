// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
    

int a1 = ReadNumber("Введите число");
int a2 = ReadNumber("Введите число");
int a3 = ReadNumber("Введите число");
int a4 = ReadNumber("Введите число");
int a5 = ReadNumber("Введите число");
int a6 = ReadNumber("Введите число");
int a7 = ReadNumber("Введите число");
int a8 = ReadNumber("Введите число");
