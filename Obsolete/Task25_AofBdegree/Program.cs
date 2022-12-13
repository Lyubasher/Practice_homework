// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. 
// (т.е нужно решить задачу без использования Math.Pow)


Console.WriteLine("Enter number A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a natural degree B:");
int B = Convert.ToInt32(Console.ReadLine());
if (B<0)
Console.WriteLine("Please enter degree > 0");
else
Console.WriteLine($"A^B = {Mult(A,B)}");

int Mult(int number, int degree)
{
    int result = 1;
    for (int i=1; i<=degree; i++)
    {
        result = result*number;
    }
    return result;
}