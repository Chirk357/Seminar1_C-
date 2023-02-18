// Задача 17
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