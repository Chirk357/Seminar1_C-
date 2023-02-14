// Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число numberA");
string numberA = Console.ReadLine();

Console.WriteLine("Введите число numberB");
string numberB = Console.ReadLine();

Console.WriteLine("Введите число numberC");
string numberC = Console.ReadLine();

int A = Convert.ToInt32(numberA);
int B = Convert.ToInt32(numberB);
int C = Convert.ToInt32(numberC);
int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;

Console.Write("max = ");
Console.WriteLine(max);