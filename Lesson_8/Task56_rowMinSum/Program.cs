// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов. (можно использовать готовую функцию)

Console.WriteLine("Enter m and n"); // вводим размер массива
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
if(m==n)
{
    Console.WriteLine("Error! This array is square!");
    Environment.Exit(0);
}

for (int i = 0; i < m; i++) // создаем рандомно двумерный массив
{
    for (int j = 0; j < n; j++)
        {
            array2d[i, j] = new Random().Next(-10, 10);
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
}
Console.WriteLine("----------------");


int[] array = new int[m]; // одномерный массив, куда будут сохраняться суммы строк 



for (int i = 0; i < m; i++) // заполнение одномерного массива 
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum + array2d[i,j];
        array[i] = sum;

    }
}

Console.Write("Line with sum of rows:");
Console.WriteLine(string.Join(",",array)); //вывод одномерного массива

int count = 1;// счетчик строк
int row = 1; // переменная, в которую будет сохраняться строка с с минимальной суммой 
int min = array[0];
for (int i = 0; i<array.Length; i++)
{
    if (min>array[i])
    {
    min = array[i];
    row = count;
    }
    count++;

}
Console.WriteLine($"Min sum in {row} row");
