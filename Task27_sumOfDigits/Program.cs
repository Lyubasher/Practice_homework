// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

Console.WriteLine("enter a number");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0)
number= -number;

int Summ(int num)
{ int sum = 0;
    while (num>0)
{
    sum = sum + num%10;
    num = num/10;
}
return sum;
}
Console.WriteLine($"The sum of the digits in the number - {Summ(number)}");
