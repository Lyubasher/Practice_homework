// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Enter array size: x, y, z");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int volume = x*y*z;
int [,,] array3d = new int [x,y,z];

if(volume>90) // если больше 90 ячеек, то будут повторяющиеся двузначные числа
{
    Console.WriteLine("Error! these array can not be created ");
    Environment.Exit(0);
}



bool Found(int[,,]array, int find) // функция для нахождения числа в массиве
{
    bool count=false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int f = 0; f < array.GetLength(2); f++)
                {
                    if (array[i,j,f]==find)
                    count=true;
                }
        }
    }
    return count;
}

for (int i = 0; i<array3d.GetLength(0); i++) // заполнение массива
{
    for (int j = 0; j<array3d.GetLength(1); j++)
    {
        for (int f=0; f < array3d.GetLength(2); f++)
        {
            int number = new Random().Next(10,100);
            while (Found(array3d,number))
            {
               number = new Random().Next(10,100);
            } 
            array3d[i,j,f] = number;
        }
    }
}
PrintArray(array3d);

void PrintArray (int [,,] array3D)
{
for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
        for (int f=0; f < array3d.GetLength(2); f++)
            {
                Console.Write($"{array3D[i, j, f]}({i},{j},{f}) ");
            }
            Console.WriteLine();
        } 
    Console.WriteLine();
    }
    
}
            




