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

int MinValue(int[] array)
{   
    int min = array[0];
    
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
        }
    }
        
    return min;
}


int MaxValue(int[] array)
{   
    int max = array[0];
    
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
        }
    }
        
    return max;
}


int Substraction(int[] array, int max, int min)
{   
    int substr = max - min;
        
    return substr;
}

int leftSide = 1;
int rightSide = 15;


int lengthOfArray = ReadNumber("Задайте длину массива");
int[] ArrayNew = GetRandomArray(lengthOfArray, leftSide, rightSide);
Console.WriteLine($"[{string.Join(", ", ArrayNew)}]");
int minimum = MinValue(ArrayNew);
int maximum = MaxValue(ArrayNew);
Console.WriteLine($"{minimum}, {maximum}");
int result = Substraction(ArrayNew, maximum, minimum);
Console.WriteLine(result);