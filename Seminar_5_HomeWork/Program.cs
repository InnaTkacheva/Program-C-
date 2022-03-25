/*
// Задача 1: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write ("Введите размер массива ");
int length = Convert.ToInt32(Console.ReadLine());

int [] array = new int [length];

int count = 0;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100,999);
    if (array[i]%2==0)
    {
       count++;
    }
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.Write ("Количество четных чисел в массиве равно " + count);




// Задача 2: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write ("Введите размер массива ");
int length = Convert.ToInt32(Console.ReadLine());

int [] array = new int [length];

int summa = 0;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0,10);
    if (i%2!=0)
    {
       Console.Write (array[i] );
       summa = summa + array[i];
    }
}
Console.WriteLine ();
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.Write ("Сумма элементов, стоящих на нечётных позициях равна " + summa);





// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
*/
// [3 7 22 2 78] -> 76

void Array ()
{
    Console.Write ("Введите размер массива ");
    int length = Convert.ToInt32(Console.ReadLine());


    double [] a = new double [length];
    a[0] = new Random().Next(0,100);
    double min = a[0];
    double max = a[0];
    for (int i = 1; i < length; i++)
    {
        a[i] = new Random().Next(0,100);
        
        if (min > a[i])
        {
            min = a[i];
        }
        if (max < a[i])
        {
            max = a[i];
        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", a));
    Console.Write("Максимальный элемент массива равен " + max);
    Console.WriteLine ();
    Console.Write("Минимальный элемент массива равен " + min);
    Console.WriteLine ();
    Console.WriteLine("Разница между максимальным и минимальным элементов массива равна "+ (max-min));
}
Array ();
