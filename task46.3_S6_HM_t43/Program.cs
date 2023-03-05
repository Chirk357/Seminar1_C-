// Задача 43. 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1*x + b1, y = k2*x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// 
// y = ax + c --> y = k1*x + b1
// y = bx + d --> y = k2*x + b2
// x = (d - c) / (a - b) --> x = (b2 - b1) / (k1 - k2)


//метод для считывания целого числа с консоли
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

(double, double) Calculations(int B1, int B2, int K1, int K2)
{
    double x = (B2 - B1) / (K1 - K2);
    // Console.WriteLine((double)(B2 - B1) / (K1 - K2));
    double y = K1 * x + B1;
    double y = k1 * (b2 - b1) / (k1 - k2) + B1;
    // Console.WriteLine((double)((K1 * x) + B1));
    return (x, y);
}


int b1 = ReadNumber("Введите число b1");
int b2 = ReadNumber("Введите число b2");
int k1 = ReadNumber("Введите число k1");
int k2 = ReadNumber("Введите число k2");
(double resultX, double resultY) = Calculations(b1, b2, k1, k2);
Console.WriteLine($"координата по X = {resultX}");
Console.WriteLine($"координата по Y = {resultY}");