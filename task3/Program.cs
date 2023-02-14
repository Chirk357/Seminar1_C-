// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите число numberA");
string numberA = Console.ReadLine();

Console.WriteLine("Введите число numberB");
string numberB = Console.ReadLine();

int A = Convert.ToInt32(numberA);
int B = Convert.ToInt32(numberB);
int max = A;
int min = B;

if (B > max) 
{
    max = B; 
    min = A;
}
else
{
    max = A; 
    min = B;
}

Console.WriteLine(max);
Console.WriteLine(min);
    

