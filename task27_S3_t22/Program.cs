// Задача №22. 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите число N");
int Num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

for(int count = 1; count <= Num; count++)
{
    int result = count * count;
    Console.WriteLine(result);
}