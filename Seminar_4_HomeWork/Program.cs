/*
// Задача 1
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Stepen (int A, int B)
{
    int C = 1;
    for ( int i = 1; i <= B; i ++) 
    {
        C = C*A;
    }
    return C;
}

Console.WriteLine("Введите первое целое натуральное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое натуральное число: ");
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Stepen (numA, numB);

Console.Write(numA + " в степени " + numB + " равняется " + numC);



// Задача 2
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum (int A)
{
    int result = 0;
    while (A > 9) 
    {
        result = result + A % 10;
        A = A / 10;
    }
    return result + A;
}

Console.WriteLine("Введите целое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int N = Sum (number);

Console.Write("Сумма цифр в числе равняется " + N);

*/

// Задача 3
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Array ()
{
    int [] a = new int [8];

    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0,10);
        Console.Write(a[i] + " ");
    }
}
Array ();


