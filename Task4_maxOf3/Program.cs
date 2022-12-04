//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter the number A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number B:");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number C:");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;

if (max > B)
{
    max = A;
}
else
{
    max = B;
}
if (max > C)
{
    Console.WriteLine("max = " + max);
}
else
{
    max = C;
    Console.WriteLine("max = " + max);
}