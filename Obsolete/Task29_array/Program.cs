// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.

Console.WriteLine("Enter the range of array numbers:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
Console.WriteLine("Enter the min of the range first, then the max");
else
{   int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(a,b);
    }
    string text = string.Join(",", array);
    Console.WriteLine($"[{text}]"); 
}

