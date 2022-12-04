// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter the number > 0 :");
int N = Convert.ToInt32(Console.ReadLine());
int M = 2;

Console.WriteLine("List of required numbers:");

while ( M <=N )
{
    Console.WriteLine(M);
    M+=2;
}