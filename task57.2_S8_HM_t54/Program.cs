// Задача 54: 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] matrix = new int[,]
{
    {9,4,2,3},
    {3,5,6,4},
    {5,3,1,4}
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

int[,] sortedMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int min = matrix[i, j];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            min = matrix[i, j];
            if (matrix[i, j + 1] < min)
            {
                int temp = matrix[i , j + 1]; 
                matrix[0, i] = matrix[matrix.GetLength(0), i];
                matrix[matrix.GetLength(0) - 1, i] = temp; ;
            }

        }
    }

}

PrintMatrix(matrix);
Console.WriteLine();