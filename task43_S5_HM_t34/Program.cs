// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}


int lengthOfArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую границу случайного диапазона");
int rightBorder = ReadNumber("Задайте правую границу случайного диапазона");

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);

Console.WriteLine($"[{string.Join(", ", myArray)}]");