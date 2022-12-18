// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] array2d = new int [4,4];



// for (int count = 1; count<=array2d.GetLength(1)*array2d.GetLength(0); count++)

int count = 1;
int firstI = 0;
int lastI = array2d.GetLength(0)-1;
int firstJ = 0;
int lastJ = array2d.GetLength(1)-1;

for (int points=1; points<=array2d.GetLength(0); points++)
{
    if ( points%2 == 1)
    FillRD(array2d);
    else
    FillLU(array2d);
}

void FillRD(int[,] array2D) // идем вправо и вниз
{
    for(int j = firstJ; j<=lastJ; j++) // заполняем первую строку
{   array2d[firstI,j] = count;
    count ++;
}
firstI++;
for (int f = firstI; f<=lastI; f++) //заполняем последний столбик
{
    array2d[f,lastJ] = count;
    count++;
}
lastJ--;
}

void FillLU(int[,] array2D) // идем влево и вверх
{
for (int k = lastJ; k>=firstJ; k--) // заполняем нижнюю строку
{   array2d[lastI,k] = count;
    count ++;
}
lastI--;
for (int l = lastI; l>=firstI; l--) // заполняем первый столбик 
{   array2d[l,firstJ] = count;
    count ++;
}
firstJ++;
}

PrintArray(array2d);

void PrintArray (int [,] array2D)
{
for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            {
                Console.Write(array2D[i,j]+" ");
            }
    Console.WriteLine();
    }
}




// вариант решения с цифрами 
// int[,] array2d = new int [4,4];

// int count = 1;


// for(int j = 0; j<4; j++)
// {   int i = 0;
//     array2d[i,j] = count;
//     count ++;
// }

// for(int i=1; i<4; i++)
// {
//     int j=3;
//     array2d[i,j] = count;
//     count ++;
// }

// for(int j = 2; j>-1; j--)
// {
//     int i=3;
//     array2d[i,j] = count;
//     count ++;
// }

// for(int i=2; i>0; i--)
// {
//     int j=0;
//     array2d[i,j] = count;
//     count ++;
// }

// for(int j = 1; j<3; j++)
// {
//     int i = 1;
//     array2d[i,j] = count;
//     count ++;
// }

// for(int j = 2; j>0; j--)
// {
//     int i = 2;
//     array2d[i,j] = count;
//     count++;
// }