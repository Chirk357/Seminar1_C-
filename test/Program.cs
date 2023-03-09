// Задача 52: 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[,]
{
    {9,5,1,5},
    {8,2,6,7},
    {3,6,7,5},
};

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[] sumOfColums(int[,] matrix)
{

    int i = 3;
    int j = 4;
    int count = 0;
    int[] newArray = new int[j];

    for (j = 0; j < matrix.GetLength(1); j++)
    {
        for (i = 0; i < matrix.GetLength(0); i++)
        {
            newArray[i] = newArray[i] + matrix[i, j];
            count++;
            
            // Console.WriteLine(count);
        }
    }
    return newArray;
}
    
    PrintMatrix(matrix);
    int[] myArray = sumOfColums(matrix);
    Console.WriteLine($"[{string.Join(", ", myArray)}]");