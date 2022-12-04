//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Enter the number A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number B:");
int B = Convert.ToInt32(Console.ReadLine());


if (A > B)
{
    Console.WriteLine("max =" +A);
}
else
{
    Console.WriteLine("max =" +B);
}