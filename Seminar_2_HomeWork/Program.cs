
/*
// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Second_number(int number)
{
    int n1 = number % 100;

    return n1/10;
}

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число " + number + " вторая цифра " + Second_number(number));


// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Third_number (int number)
{
    int n=number;
    if(n < 100)
    {
        Console.WriteLine("Число " + number + " третьей цифры нет");
    }
    while (n > 999)
    {
        n = n / 10;
    }
    
    Console.WriteLine("Число " + number + " третья цифра " + n % 10);
       
}
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Third_number (number);

*/

// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


void Day (int num)
{
    if(num > 7) 
    {
        Console.Write("Этого дня недели не существует");
        return;
    }
    if(num > 5) 
    {
        Console.Write("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}

Console.Write("Введите Ваше номер дня недели: ");
int input = Convert.ToInt32(Console.ReadLine());

Day (input);

