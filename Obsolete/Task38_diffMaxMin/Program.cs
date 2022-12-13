// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// Диапазон любой, ввод зависит от пользователя. (размер, значения)


Console.WriteLine("Enter array size:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter array numbers:");
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
}
string text = string.Join("; ", array);
Console.WriteLine($"[{text}]"); 

Console.WriteLine($"The difference between the max and min = {MaxMin(array)}");

double MaxMin(double[] line)
{
    double diff = 0;
    double max = line[0];
    double min = line[0];
    for (int i = 0; i < line.Length; i++)
    {
        if (line[i]>max)
        {
            max = line[i];
        }
        if (line[i]<min)
        {
            min = line[i];
        }
    }
    diff = max - min;
    return diff;
}