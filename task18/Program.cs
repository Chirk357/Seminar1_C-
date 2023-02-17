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