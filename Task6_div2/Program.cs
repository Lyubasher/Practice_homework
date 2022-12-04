//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Enter the number ");
int A = Convert.ToInt32(Console.ReadLine());

if (A % 2 == 0)
{
    Console.WriteLine("Yes, " + A + " is an even number" );
}
else
{
    Console.WriteLine("No, " + A + " is an odd number");
}