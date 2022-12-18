// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Enter M and N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (N<=M|| M<0 || N<0)
{
    Console.WriteLine("Error! Please enter natural numbers and M>N");

}
else
{
    Console.WriteLine($"Sum from M to N: {SumMN(M,N)}");
}

int SumMN (int m, int n)
{
    if(m>n)
    {
        return 0;
    }
    return m + SumMN(m+1,n);
    
}