// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            Console.Write(matrix[j, i] + " ");
            sum += matrix[j, i];
        }
        Console.Write($" -> sum:{sum}");
        Console.WriteLine();
    }
}


int FindRowWithMinSum(int[,] matrix)
{
    int[] indexRow = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            indexRow[j] += matrix[i, j];
        }
    }

    int indexOfMinRow = 0;
    for (int k = 1; k < indexRow.Length; k++)
    {
        if (indexRow[k] < indexRow[indexOfMinRow])
        {
            indexOfMinRow = k;
        }
    }
    return indexOfMinRow + 1;
}



int[,] Fill(int length_x, int length_y, int leftnum = 0, int rightnum = 10)
{
    int[,] matrix = new int[length_y, length_x];
    for (int i = 0; i < length_y; i++)
    {
        for (int j = 0; j < length_x; j++)
        {
            matrix[i, j] = Random.Shared.Next(leftnum, rightnum);
        }
    }
    return matrix;
}


int[,] matrix = Fill(5, 3, 0, 100);
PrintMatrix(matrix);
Console.WriteLine($"{FindRowWithMinSum(matrix)} строка");