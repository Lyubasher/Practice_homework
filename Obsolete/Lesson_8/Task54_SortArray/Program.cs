// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива. 
// (можно использовать готовую функцию)


Console.WriteLine("Enter m and n"); // вводим размер массива
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2d = new int[m, n];

for (int i = 0; i < m; i++) // создаем рандомно массив
{
    for (int j = 0; j < n; j++)
        {
            array2d[i, j] = new Random().Next(-10, 10);
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
}
Console.WriteLine("----------------");
int[] array = new int[n];

for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++)
    {
        array[j]=array2d[i,j];
    }
    Array.Sort(array);
    Array.Reverse(array);
    Console.WriteLine(string.Join(" ", array));
}