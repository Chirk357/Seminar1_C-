//  Задача 17
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
// Решение методом.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int x = ReadNumber("Введите координаты точки по X");
int y = ReadNumber("Введите координаты точки по Y");

Console.WriteLine(
    x > 0 && y > 0 ? "1я четверть":
    x < 0 && y > 0 ? "2я четверть":
    x < 0 && y < 0 ? "3я четверть":
    x > 0 && y < 0 ? "4я четверть":
    "Невозможно определить координаты"
);
