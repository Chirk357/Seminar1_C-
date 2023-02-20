// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i >= 1000; i++)
{
    Console.WriteLine(newNumber = number / 10);
}
Console.WriteLine(newNumber);