// Задача 52. Задайте двумерный массив (вручную) из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Enter array size: m and n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array2d = new double[m,n];
Console.WriteLine("Enter numbers with semicolon");

for (int i = 0; i < m; i++)
{
    string[] points = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = Convert.ToDouble(points[j]);
    }
}
Console.WriteLine("======================");
PrintArray(array2d);
Console.WriteLine();
Average(array2d);

double Average(double[,] Array2d)
{
    double avg = 0;
    for (int j = 0;  j < Array2d.GetLength(1); j++)
    {
        double sum = 0;
         for (int i = 0; i < Array2d.GetLength(0); i++)
        {
            sum = Array2d[i,j] + sum;
        }

        avg = sum/Array2d.GetLength(0);
        Console.WriteLine($"The arithmetic mean in the column {avg}");

    }
    return avg;
}

void PrintArray (double [,] Array2d)
{
for (int i = 0; i < Array2d.GetLength(0); i++)
    {
        for (int j = 0; j < Array2d.GetLength(1); j++)
            {
                Console.Write(Array2d[i,j]+" ");
            }
    Console.WriteLine();
    }
}