// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    string str = Convert.ToString(number);
    if (str.Length<=3)
    {
       Console.WriteLine("the thitd digit is missing."); 
    }
    else
    {
        Console.WriteLine("the third digit is " +str[3]);
    }
}

if (number > 0)
{
    string str = Convert.ToString(number);
    if (str.Length<=2)
    {
        Console.WriteLine("the thitd digit is missing.");
    }
    else
    {
        Console.WriteLine("the third digit is " +str[2]);
    }
}

