/*
// Задача 1
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int A;
int Summa (int A)
{
    int c = 1;
    int sum = 0;
    while (c <= A)
    {
        sum = sum + c;
        c++;
    }
    return sum;
    }
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Summa(number));


// Задача 3
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int A;
int Proizv (int A)
{
    int c = 1;
    int proizv = 1;
    while (c <= A)
    {
        proizv = proizv * c;
        c++;
    }
    return proizv;
    }
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Proizv(number));

// Задача 2
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Number (int N)
{
    int count = 0;
    while (N >= 1)
    {
        N = N/10;
        count++;
    }
    return count;
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Number(n));
*/

// Задача 4
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.



void array (int num)
{
    for (int i = 0; i < 8; i++)
    {
        num = new Random().Next(0,2);
        Console.Write($"{num} ");
    }
}
int num = 0;
array (num);






