// Задача 23: 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

for(int count = 1; count <= number; count++)
{
    double result = Math.Pow(count, 3);
    Console.WriteLine(result);
}
