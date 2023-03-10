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


PrintMatrix(matrix);
Console.WriteLine();

int i = 3;
int j = 4;

double average = 0;

for (j = 0; j < matrix.GetLength(1); j++)
{
    average = 0;
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        average += matrix[i, j];
        
    }
    average = average / matrix.GetLength(0);
    Console.WriteLine($"Среднее для столбца {average:f2}");
}


