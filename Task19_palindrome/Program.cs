// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter five-digit number:");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number > -100000 && number < -9999 || number > 9999 && number < 100000)
{
    if(number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
    Console.WriteLine("It is a palindrome");
    else
    Console.WriteLine("It is not a palindrome");
}
else
{
   Console.WriteLine("you enter the incorrect number:");
}



