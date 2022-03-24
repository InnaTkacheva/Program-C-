/* 
// Задача 1: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

void Array ()
{
    int [] a = new int [12];
    int summapol = 0;
    int summaotr = 0;
    for (int i = 0; i < 12; i++)
    {
        a[i] = new Random().Next(-9,10);
        Console.Write(a[i] + " ");
        if (a[i] > 0)
        {
            summapol = summapol + a[i];
        }
        else
        {
            summaotr = summaotr + a[i];
        }
    }
    Console.Write("Сумма положительных чисел равна "+ summapol + " Сумма отрицательных чисел равна " + summaotr);
}
Array ();


// Задача 2: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

void Array (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * - 1;
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
int [] array1 = {5, 6 , -8 , 125, -456};
Array (array1);


// Задача 3: 
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int [] array = {15, 86 , -58 , 12, 5, -4, 56};
Console.Write ("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());
int A = 1;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        A = 2;
        Console.Write ("Искомое число присутствует");      
        break;
    }
}
if (A == 1)
{
    Console.Write ("Искомое число отсутствует");
}


// Задача 4: 
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


int [] a = new int [123];
int summa = 0;
for (int i = 0; i < 123; i++)
{
    a[i] = new Random().Next(0,1000);
    if (a[i] <= 99 && a[i] >= 10)
    {
       summa++;
    }
}
Console.WriteLine("[{0}]", string.Join(", ", a));
Console.Write ("Количество элементов заданного диапазона равно " + summa);

*/

// Задача 5:
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

void Array (int [] BasicArray)
{
    int N;
    
    if (BasicArray.Length % 2 == 0)
    {
        N = BasicArray.Length / 2;
    }
    else
    {
        N = BasicArray.Length / 2 + 1;
    }
    int B = BasicArray [N-1];
    int [] Proizv = new int [N];
       
    for (int i = 0; i < BasicArray.Length / 2; i++)
    {
        Proizv [i] = BasicArray [i] * BasicArray [BasicArray.Length-1-i];
    }
    if (BasicArray.Length % 2 > 0)
    {
        Proizv[N-1] = B;
    }
    Console.Write ("Итоговый массив имеет вид ");
    Console.WriteLine($"[{string.Join(", ", Proizv)}]");
}
int [] array1 = {1, 8, 6, -5, 7, 2, 5, -4, 3};

Array (array1);