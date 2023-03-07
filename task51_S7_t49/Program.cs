﻿// Задача 49: 
// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{

    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] UnevenIndexes(int[,] matrix)
{

    for(int i = 1; i < matrix.GetLength(0); i = i + 2)
    {
        for(int j = 1; j < matrix.GetLength(1); j = j + 2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }

    return matrix;
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
Console.WriteLine();
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] myUnevenMatrix = UnevenIndexes(myMatrix);
PrintMatrix(myUnevenMatrix);
Console.WriteLine();



// int ReadNumber(string messageToUser)
// {
//     Console.WriteLine(messageToUser);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
// {

//     int[,] matrix = new int[rows, columns];

//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
                        
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void unEvenMatrix(int[,] matrix)
// {
//     for(int i = 1; i < matrix.GetLength(0); i += 2)
//     {
//         for(int j = 1; j < matrix.GetLength(1); j += 2)
//         {
//             matrix[i,j] =  matrix[i,j] *  matrix[i,j];
//         }
//     }
// }

// int m = ReadNumber("Введите количество строк:");
// int n = ReadNumber("Введите количество столбцов:");
// int[,] myMatrix = GetRandomMatrix(m, n);
// PrintMatrix(myMatrix);
// Console.WriteLine();
// unEvenMatrix(myMatrix);