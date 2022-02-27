/*
// Задача 1: 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if (value1 > value2)
{
    Console.Write("Наибольшее число ");
    Console.Write(value1);
}
else 
{
    Console.Write("Наибольшее число ");
    Console.Write(value2);
}


// Задача 2: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int value3 = Convert.ToInt32(Console.ReadLine());
int value_max = value1;

if (value_max < value2)
{
    value_max = value2;
}
if (value_max < value3)
{
    value_max = value3;
}
Console.Write("Наибольшее число ");
Console.Write(value_max);


//Задача 3: 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите целое число: ");
int value = Convert.ToInt32(Console.ReadLine());

if (value % 2 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
*/

//Задача 4: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = 2;

while (A <= N)
{
        if (A % 2 == 0)
    {
        Console.WriteLine(A);
    }
A+=1;
}