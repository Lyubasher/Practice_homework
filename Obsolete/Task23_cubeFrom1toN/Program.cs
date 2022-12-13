// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Enter number N:");
int N = Convert.ToInt32(Console.ReadLine()); 

if (N<=0)
Console.WriteLine("Please input N>0!");
else
{
    Console.WriteLine("Table of cubes:");
    for (int i = 1; i<=N; i++)
{
    Console.WriteLine(i*i*i);
}
}
