// Задача 21: 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Coordinates(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int ax = Coordinates("Введите координаты точки по X");
int ay = Coordinates("Введите координаты точки по Y");
int az = Coordinates("Введите координаты точки по Z");

int bx = Coordinates("Введите координаты точки по X");
int by = Coordinates("Введите координаты точки по Y");
int bz = Coordinates("Введите координаты точки по Z");

