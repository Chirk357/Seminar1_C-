// Задача 21: 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Coordinates(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int ax = Coordinates("Введите координаты точки a по X");
int ay = Coordinates("Введите координаты точки a по Y");
int az = Coordinates("Введите координаты точки a по Z");

int bx = Coordinates("Введите координаты точки b по X");
int by = Coordinates("Введите координаты точки b по Y");
int bz = Coordinates("Введите координаты точки b по Z");

double result = Math.Sqrt(Math.Pow((ax - bx) , 2) + Math.Pow((ay - by) , 2) + Math.Pow((az - bz) , 2));
Console.WriteLine($"{result:f2}");