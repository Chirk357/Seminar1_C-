// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница


Console.WriteLine("Введите число");
string Answer = Console.ReadLine();
int day = Convert.ToInt32(Answer);

if (0 < day < 8)
{
    if (day == 1)
    {
    Console.WriteLine("понедельник");
    }
    else if (day == 2)
    {
    Console.WriteLine("вторник");
    }

    else if (day == 3)
    {
    Console.WriteLine("среда");
    }

    else if (day == 4)
    {
        Console.WriteLine("четверг");
    }

    else if (day == 5)
    {
        Console.WriteLine("пятница");
    }

    else if (day == 6)
    {
        Console.WriteLine("суббота");
    }

    else if (day == 7)
    {
        Console.WriteLine("воскресенье");
    }
}
    else
    {
        Console.WriteLine("нет такого дня");
    }