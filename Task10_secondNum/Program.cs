// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter three-digit number:");

int number = Convert.ToInt32(Console.ReadLine());

if (number > -999 && number < -99)
{
    number = - number;
    Console.WriteLine("the second digit:" +number % 100 / 10);
}

else
{
    if (number > 99 && number < 1000)
    {
        Console.WriteLine("the second digit:" +number % 100 / 10);
    }
    else 
    Console.WriteLine("you enter the incorrect number:");

}

