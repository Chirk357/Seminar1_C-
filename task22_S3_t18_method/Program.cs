﻿// Задача №18. 
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// 1 -> “x > 0 && y > 0” 
// 2 -> “x < 0 && y > 0” 
// 3 -> “x < 0 && y < 0” 
// 4 -> “x > 0 && y < 0”
// 5 -> “Неверно введен номер четверти” 

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введите номер четверти");

if (number == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if(number == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if(number == 3)
{
   Console.WriteLine("x < 0 && y < 0"); 
}
else if(number == 4)
{
   Console.WriteLine("x > 0 && y < 0"); 
}
else
{
    Console.WriteLine("Неверно введен номер четверти");
}