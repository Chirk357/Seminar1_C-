// Задача 53: 
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.


int[,] matrix = new int[,]{
    {0,5,1,2},
    {5,2,6,7},
    {3,6,7,5},
    {2,5,6,3}
};

void ReplaceRows(int[,] matrix)
{
    // нужен только один цикл, потому что мы в люом массиве будем менять 1ю(
    // (GetLength(0)) и последнюю строку(GetLength(0) - 1). А значит нужно перелистывать только столбцы.
    for(int i = 0; i < matrix.GetLength(1); i++)                                          
    {
        int temp = matrix[0, i]; // в темп кладем значение по индексу в 0й строке и столбце i
        matrix[0, i] = matrix[matrix.GetLength(0)-1, i];
        matrix[matrix.GetLength(0)-1, i] = temp;
    }
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);
Console.WriteLine();
ReplaceRows(matrix);
PrintMatrix(matrix);