// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Диапазон любой, ввод размера и значений пользователем

Console.WriteLine("Enter array size:");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
string text = string.Join(",", array);
Console.WriteLine($"[{text}]"); 
Console.WriteLine($"The sum of numbers with odd indexes = {SumOdd(array)}");

int SumOdd(int[] points)
{
    int sum = 0;
    for (int i=1; i < size; i+=2)
    {
        sum = sum + points[i];
    }
    return sum;
}