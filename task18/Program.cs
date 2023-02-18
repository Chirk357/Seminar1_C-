// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координату точки по Х");
int x = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите координату точки по Y");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка в 1й четверти");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка во 2й четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка в 3й четверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка в 4й четверти");
}
else
{
    Console.WriteLine("Невозможно определить координатную четверть");
}


// Console.WriteLine(
//     x > 0 && y > 0 ? "Точка в 1й четверти":
//     x < 0 && y > 0 ? "Точка во 2й четверти":
//      "Невозможно определить координатную четверть"
// );