// Задача 32: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int[] array = { 1, 4, 57, 2, 2, 66, 83, 4, 74, 41, 444 };
int i = 0;
ок

for(i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1);
}
Console.WriteLine(array[i]);


// int [] a = {1,2,-3,5};
// void function()
// {
//     for(int i =0 ; i< a.Length;i++) a[i] *=(-1);
//     foreach (var item in a) Console.Write($"{item} ,");  
// }

// function();