

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
     
}

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}

const int LENGTH