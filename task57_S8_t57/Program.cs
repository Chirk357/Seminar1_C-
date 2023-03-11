// Задача 57: 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 9)
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

void PrintRepeats(int[,] matrix)
{
    int[] repeats = new int[10];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            //int index = matrix[i, j];
            repeats[matrix[i, j]]++;
        }
    }

    for (int i = 0; i < repeats.Length; i++)
    {
        Console.WriteLine($"{i} повторяется {repeats[i]} раз");
    }
}


int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
PrintRepeats(myMatrix);

// В группе
// int[,] matrix = new int[,]
// {
//     {0,4,2,5,3}, 
//     {3,5,6,4,2},
//     {5,3,5,1,4}
// };

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[] CounterDictionary = new int[10];// самостоятельно задали

// void Dictionary(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for(int k = 0; k < CounterDictionary.Length; k++)
//             {
//                 if(matrix[i,j] == k)
//                 {
//                     CounterDictionary[k] ++;
//                 }
//             }
//         }
//     }
// }

// void PrinCounter(int[] dictionary)
// {
//     for(int i = 0; i < dictionary.Length; i++)
//     {
//         if(dictionary[i] != 0)
//         {
//             Console.WriteLine($"{i} -> {dictionary[i]}");
//         }
//     }
// }

// PrintMatrix(matrix);
// Dictionary(matrix);
// PrinCounter(CounterDictionary);