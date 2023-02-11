// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет



// Первый способ
Console.WriteLine("Введите число A");
string AnswerA = Console.ReadLine();

Console.WriteLine("Введите число B");
string AnswerB = Console.ReadLine();

int numberA = Convert.ToInt32(AnswerA);
int numberB = Convert.ToInt32(AnswerB);

if ((numberA * numberA) == numberB)
{
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}

