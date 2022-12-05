// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter number > 0:");

string number = Console.ReadLine();
if (number.Length<=2)
{
    Console.WriteLine("the thitd digit is missing.");
}
else
{
    Console.WriteLine("the third digit is " +number[2]);
}

