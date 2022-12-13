// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine ("Enter the number of the day of the week:");

int number = Convert.ToInt32(Console.ReadLine());

if (number<=0 || number>7)
{
    Console.WriteLine("you enter an incorrect number");
}
else
{
    if (number==7 || number==6)
    {
        Console.WriteLine ("this is a weekend");
    }
    else
    {
        Console.WriteLine ("this is a weekday");
    }
}