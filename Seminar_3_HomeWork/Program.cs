
/*

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int palindrom;
int number;
Console.Write("Введите пятизначное число: ");
number = Convert.ToInt32(Console.ReadLine());;

int a1 = number % 10;
int a2 = number / 10 % 10;
int a3 = number / 100 % 10;
int a4 = number / 1000 % 10;
int a5 = number / 10000;
palindrom = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;

if (palindrom == number)
{
    Console.WriteLine("Число является палиндромом");
}
else 
{
    Console.WriteLine("Число не является палиндромом");
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistance (double x1, double y1, double z1, double x2, double y2,  double z2)
{
    double xDistance = x2 - x1; 
    Console.WriteLine (xDistance);
    double yDistance = y2 - y1;
    Console.WriteLine (yDistance);
    double zDistance = z2 - z1;
    Console.WriteLine (zDistance);

    return Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2) + Math.Pow(zDistance,2));
}

double distance;
double xA, yA, zA, xB, yB, zB;

Console.Write("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point A: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point B: ");
zB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(GetDistance(xA,yA,zA,xB,yB,zB));

*/


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number;
int index = 1;
Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

while (index <= number)
{
    Console.WriteLine(Math.Pow(index,3));
    index++;
}

