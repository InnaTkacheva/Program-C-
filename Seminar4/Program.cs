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

// другое решение

int ArythmSum(int A)
{
    int result = 0;
    int i = 1;
    while (i <= A)
    {
        result = result + i;
        i++;
    }
    return result;
}
Console.WriteLine("Введите ваше целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Cумма чисел от 1 до {numA} равна {ArythmSum(numA)}");


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

// другое решение 

int Factorial(int N)
{
    int result = 1;
    for ( int i = 1;i <= N;i++) result = result*i;
    return result;
}

Console.WriteLine("Введите ваше целое число: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numN < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Произведение чисел от 1 до {numN} равна {Factorial(numN)}");

/*
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


// другое решение


void Dlinna (int N)
{
    int l = 1;
    while (Math.Abs(N/10) > 1)
    {
        N = N /10;
        l++;
    }
    Console.WriteLine("Количество цифр в введенном числе " + l);
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Dlinna(number);


/*
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


//другое решение

void bitArray ()
{
    int [] a = new int [8];

    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0,2);
        Console.Write(a[i] + " ");
    }
}
bitArray ();
*/


