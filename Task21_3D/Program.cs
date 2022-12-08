// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Enter coordinates x, y, z for point A:"); // A (x1,y1,z1)

double [] point = new double [6]; // {x1,y1,z1,x2,y2,z2}

for (int i = 0; i < 3; i++) // сначала цикл поработает для точки А, затем запросит и заполнит координаты для В
{
point[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Enter coordinates x, y, z for point B:"); // B (x2,y2,z2)
for (int i = 3; i < 6; i++)
{
point[i] = Convert.ToDouble(Console.ReadLine());
}

double AB = Math.Sqrt((point[3]-point[0])*(point[3]-point[0])+(point[4]-point[1])*(point[4]-point[1])+
(point[5]-point[2])*(point[5]-point[2]));
Console.WriteLine(AB);