// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//вывод случайный

Console.WriteLine("Enter array size:");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100,1000);
}
string text = string.Join(",", array);
Console.WriteLine($"[{text}]"); 
Console.WriteLine($"Quantity even numbers = {EvenNum(array)}");

int EvenNum(int[] Array)
{
    int count = 0;
    for(int i=0; i<Array.Length; i++)
    {
        if(Array[i]%2==0)
        count++;
    }
    return count;
}