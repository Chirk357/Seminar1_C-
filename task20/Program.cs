// Задача 17
// Методом , когда повторяются команды и создаем сами команду REadNumber. 
// Мы пишем ReadNumber
// Console.WriteLine("Введите координату точки по Х");
// int x = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Введите координату точки по Y");
// int y = Convert.ToInt32(Console.ReadLine()); 

int ReadNumber(string message) || 
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
  
}


int x = ReadNumber("")