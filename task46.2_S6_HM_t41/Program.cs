// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



int count = 0;
string stop = "stop";
while(true)
{
    string userAnswer = Console.ReadLine()!;
    if(userAnswer.ToLower() == stop)
    {
        break;
    }
    else
    {
        int number = Convert.ToInt32(userAnswer);
        if(number > 0)
        {
            count++;
        }
    }
}

Console.WriteLine(count);