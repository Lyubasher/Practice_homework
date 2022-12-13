// Задача 16 - Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

Console.WriteLine("Enter the number A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number B:");
int B = Convert.ToInt32(Console.ReadLine());

if ( A == B*B || B == A*A)
Console.WriteLine("Yes");
else
Console.WriteLine("No");