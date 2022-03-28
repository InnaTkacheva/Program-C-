/*
// Задача 1:
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины. (A < B + C)

void treugolnik (int A, int B, int C)
{
    if (A < (B + C) && B < (A + C) && C < (A + B)) 
    {
        Console.WriteLine("Треугольник может существовать");
    } 
    else 
    {
        Console.WriteLine("Треугольник не может существовать");
    }
}

Console.Write ("Введите число A ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число B ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число C ");
int sideC = Convert.ToInt32(Console.ReadLine());

treugolnik (sideA, sideB, sideC);

// Задача 2:
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void transformation (int Num)
{
    string answer ="";
    while (Num > 0)
    {
        answer = Convert.ToString(Num%2) + answer;
        Num = Num/2;
    }
    Console.WriteLine(answer);
}

Console.Write ("Введите число в десятичной системе ");
int number = Convert.ToInt32(Console.ReadLine());

transformation (number);


*/
// Задача 3:
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Fibbon (int Num)
{
    int [] array = new int [Num];
    array [0] = 0;
    array [1] = 1;
    Console.Write("0 1 ");
    for (int i = 2; i < Num; i++)
    {
        array [i] = array [i-1] + array [i-2];
        Console.Write(array[i] + " ");
    }
}

Console.Write ("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());

Fibbon (number);



/*
// Задача 4:
// Напишите программу, которая будет создавать копию заданного двумерного массива 
// с помощью поэлементного копирования. (2 строки b 3 столбца)

int [,] matrix = new int [2, 3];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix [i, j] = new Random().Next (0, 10);
        Console.Write ($"{matrix [i,j]} ");
    }
    Console.WriteLine();
}
// другое решение
// Напишите программу, которая будет создавать копию заданного двумерного массива 
// с помощью поэлементного копирования. (2 строки b 3 столбца)

void PrintArray (int [,] matrix)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matrix [i, j] = new Random().Next (0, 10);
            Console.Write ($"{matrix [i,j]} ");
        }
        Console.WriteLine();
    }

}
int [,] matrix = new int [2, 3];
PrintArray (matrix);
*/
