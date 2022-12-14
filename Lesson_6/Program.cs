Console.WriteLine("Chooce task");
Console.WriteLine("task1: Quantity of Positive numbers in the line witn M  numbers:");
Console.WriteLine("task2: The intersection point of 2 straight lines:");
int n = Convert.ToInt32(Console.ReadLine());

switch(n)
{
    case 1:
        Task1();
        break;
    case 2:
        Task2();
        break;
    default:
    break;
}

void Task1()
{
    Console.WriteLine("Enter numbers with commas");
    string[] array = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries); // вводится строка с числами (числа целые) через запятую
    Console.WriteLine($"Quantity of Positive numbers in the line: {PositiveNumb(array)}");
}

// Метод Split() возвращает массив строк, сгенерированных путем разделения исходной строки, разделенных 
// //    разделителями, переданными в качестве параметра в методе Split().
// StringSplitOptions.RemoveEmptyEntries - говорит, что нужно удалить все пустые подстроки
 


int PositiveNumb(string[] points) // на вход в функцию строчный массив
{
    int count = 0;
    for (int i = 0; i < points.Length; i++)
    {
        if(Convert.ToInt32(points[i]) > 0) // переводим элемент массива string в int 
        {
            count ++;
        }
    }
    return count;
}

void Task2()
{
    Console.WriteLine("Enter b1, k1, b2, k2 for straight lines:  y = k1 * x + b1 and y = k2 * x + b2:");
    double b1 = Convert.ToDouble(Console.ReadLine());
    double k1 = Convert.ToDouble(Console.ReadLine());
    double b2 = Convert.ToDouble(Console.ReadLine());
    double k2 = Convert.ToDouble(Console.ReadLine());
    if (k1==k2|| k1==k2 && b1==b2)
    Console.WriteLine("Straight lines are parallel or coincide. ");
    else
    {
        double[] array = Coordinates(b1,k1,b2,k2);
        string text = string.Join(";", array);
        Console.WriteLine($"The coordinate of the intersection of the lines:[{text}]"); 
    }
}




double[] Coordinates (double a1, double f1, double a2, double f2) // y=f1*x + a1 and y = f2*x +a2
{
    double[] points = new double[2];
    points[0] = (a2-a1)/(f1-f2);
    points[1] = f1*((a2-a1)/(f1-f2))+a1;
    return points;
} 

