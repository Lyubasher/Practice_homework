// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//          ⎧n + 1                  m = 0
// A(m,n) = ⎨A(m - 1, 1)            m > 0, n = 0
//          ⎩A(m - 1,A(m, n - 1))   m > 0, n > 0


Console.WriteLine("Enter M and N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

if (M<0 || N<0)
{
    Console.WriteLine("Error! Please enter numbers M>0, N>0");

}
else
{
    Console.WriteLine($"Result: {Ackermann(M,N)}");
}

int Ackermann(int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    if (m>0 && n ==0)
    {
        return Ackermann(m-1,1);
    }
    if(m>0 && n>0)
    {
        return Ackermann(m-1,Ackermann(m,n-1));
    }
    return Ackermann(m,n);
}