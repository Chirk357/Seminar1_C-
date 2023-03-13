// Задача 62. 
// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

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
        // Console.Write($" -> sum:{sum}");
        Console.WriteLine();
    }
}

void SpiralFillMatrix(int[,] matrix)
{
    int[] rows = new int[16] {0, 0, 0, 0, 1, 2, 3, 3, 3, 3, 2, 1, 1, 1, 2, 2};
    int[] cols = new int[16] {0, 1, 2, 3, 3, 3, 3, 2, 1, 0, 0, 0, 1, 2, 2, 1};
    int num = 1;
    for (int i = 0; i < rows.Length; i++)
    {
        matrix[rows[i], cols[i]] = num;
        num++;
    }
}

int[,] matrix = new int[4, 4];
SpiralFillMatrix(matrix);
PrintMatrix(matrix);