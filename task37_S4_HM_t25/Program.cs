// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
     
}

int Multiply(int A, int B)
{
    int result = 1;
    int count = 1;

    if(B >= 1)
    {
       
       for(count = 1; count <= B; count++)
        {
           result = result * A;
        }
    }
    
    else
    {
        Console.WriteLine("over");
    }
    return result;
}

int valueone = ReadNumber("Введите число A");
int valuetwo = ReadNumber("Введите число B, где B > 0");
Console.WriteLine();
int res = Multiply(valueone, valuetwo);
Console.WriteLine(res);