// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
        Console.WriteLine();
    }
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

int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int[,] MMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < MMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MMatrix.GetLength(1); j++)
        {
            MMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return MMatrix;
}


int[,] matrix1 = Fill(4, 4, 1, 10);
int[,] matrix2 = Fill(4, 4, 1, 10);

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(MatrixMultiply(matrix1, matrix2));

