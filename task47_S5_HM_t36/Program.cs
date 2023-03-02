// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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
        array[i] = Random.Shared.Next(leftRange, rightRange);
    }

    return array;
}

int SumOfNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i % 2) != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}


int leftSide = 0;
int rightSide = 10;


int lengthOfArray = ReadNumber("Задайте длину массива");
int[] ArrayNew = GetRandomArray(lengthOfArray, leftSide, rightSide);
Console.WriteLine($"[{string.Join(", ", ArrayNew)}]");
int SumOfElements = SumOfNumbers(ArrayNew);
Console.WriteLine(SumOfElements);