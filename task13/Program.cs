// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Console.WriteLine("Введите число A");
string AnswerA = Console.ReadLine();

Console.WriteLine("Введите число B");
string AnswerB = Console.ReadLine();

int numberA = Convert.ToInt32(AnswerA);
int numberB = Convert.ToInt32(AnswerB);

if ((numberA * numberA) == numberB || numberB * numberB == numberA)
{
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}
