// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

Console.WriteLine("Введите число 1");
Console.WriteLine("Введите число 2");
string userNumber1 = Console.ReadLine();
string userNumber2 = Console.ReadLine();
int userAnswer1 = Convert.ToInt32(userNumber1);
int userAnswer2 = Convert.ToInt32(userNumber2);
if (userNumber1 * userNumber2 == userNumber2)
{
Console.WriteLine("да");
}

// https://github.com/SolodkovKM/geekbrainsc-