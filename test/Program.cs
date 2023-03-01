﻿// Задача 34: 
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
    for(i = 0; i < array.Length; i++)
    {
       array[i] = array[i] % 2;
       if(array[i] == 0)
       {
            return i;
       }
    //    else
    //    {
    //         return Console.WriteLine("error");
    //    }
    }
    return i;
}

int lengthOfArray = ReadNumber("Задайте длину массива");
int[] myArray = GetRandomArray(lengthOfArray);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
int countOfI = EvenNumber(myArray);
Console.WriteLine($"{countOfI}");