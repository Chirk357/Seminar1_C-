// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



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

(int,int) MinMax(int[] array)
{   
    int min = array[0];
    int max = array[1];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if(array[i] > max) max = array[i];
    }
        
    return (min, max);
}



int Substraction(int[] array, int max, int min)
{   
    int substr = max - min;
        
    return substr;
}

int leftSide = 0;
int rightSide = 20;


int lengthOfArray = ReadNumber("Задайте длину массива");
int[] ArrayNew = GetRandomArray(lengthOfArray, leftSide, rightSide);
Console.WriteLine($"[{string.Join(", ", ArrayNew)}]");
(int minimum, int maximum) = MinMax(ArrayNew);
Console.WriteLine($"{minimum}, {maximum}");
int result = Substraction(ArrayNew, maximum, minimum);
Console.WriteLine(result);