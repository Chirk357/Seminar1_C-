// Задача 17
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

// Решение методом , когда повторяются команды и создаем сами команду REadNumber. 
// Мы пишем ReadNumber
// Console.WriteLine("Введите координату точки по Х");
// int x = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Введите координату точки по Y");
// int y = Convert.ToInt32(Console.ReadLine()); 

double ReadNumber(string messageToUser)  
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}


double xa = ReadNumber("Введите координату точки A по X");
double ya = ReadNumber("Введите координату точки A по Y");
double xb = ReadNumber("Введите координату точки B по X");
double yb = ReadNumber("Введите координату точки B по Y");

double result = Math.Sqrt((Math.Pow((xb - xa) , 2) + Math.Pow((yb - ya) , 2))); 
Console.WriteLine($"{result:f2}");