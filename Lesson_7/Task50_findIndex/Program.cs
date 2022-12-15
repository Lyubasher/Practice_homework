// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, 
// и возвращает индекс этого элемента или же указание, что такого элемента нет. Если элементов несколько, 
// то выводим позицию каждого. Двумерный массив задаётся на ваш выбор.

Console.WriteLine("Enter m and n"); // вводим размер массива
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number to find:");
int find = Convert.ToInt32(Console.ReadLine()); // вводим искомое число
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

Find(array2d,find); // вызов функции

void Find(int[,] points, int number) //функция поиска числа
{   int f = -1;                      // приравниваем к -1, для условия, если элемент не будет найден
    int g = -1;

for (int i = 0; i < points.GetLength(0); i++)
{
    for (int j = 0; j < points.GetLength(1); j++)
        { if (points[i,j]==number)
        {
         f = i;
         g = j;
         Console.WriteLine($"Index of find:[{f},{g}]");
        }
        }
}

if (f ==-1 && g == -1)
Console.WriteLine("The number was not found in the array");
}