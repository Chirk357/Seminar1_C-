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

int[] GetRandomArray(int length)
{
    int leftRange = 100;
    int rightRange = 999;
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}


int EvenNumber(int[] array)
{
    int i = 0;
    int count = 0;
    for (i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            Console.WriteLine(i);
            count++;
        }
    }
    return count;
}

int lengthOfArray = ReadNumber("Задайте длину массива");
int[] myArray = GetRandomArray(lengthOfArray);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
int count = EvenNumber(myArray);
Console.WriteLine(count);