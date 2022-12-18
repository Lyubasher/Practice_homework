// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.


Console.WriteLine("Enter m and n for the first matrix"); 
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

Console.WriteLine("Enter m and n for the second matrix"); 
int m1 = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m1, n1];
int[,] mult = new int[m,n1];

if(n != m1)
{
    Console.WriteLine("Error! these matrices cannot be multiplied!");
    Environment.Exit(0);
}

for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
}
Console.WriteLine("----------------");

for (int i = 0; i < m1; i++) 
{
    for (int j = 0; j < n1; j++)
        {
            matrix1[i, j] = new Random().Next(0, 10);
            Console.Write(matrix1[i, j] + " ");
        }
        Console.WriteLine();

}

Console.WriteLine("----------------");

for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n1; j++)

    {
        for (int f=0; f < n; f++)
        {
        mult [i,j] = mult[i,j] + matrix[i,f] * matrix1[f,j]; 
        
        }
    }
}
Console.WriteLine($"The result of matrix multiplication :");
PrintArray(mult);

void PrintArray (int [,] array2d)
{
for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
            {
                Console.Write(array2d[i,j]+" ");
            }
    Console.WriteLine();
    }
}