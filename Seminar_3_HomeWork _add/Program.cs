// Доп задача
// Пользователь вводит целые числа до тех пор, пока не введет ноль. Вывести на экран первые два максимальных числа и первые два минимальных числа из ряда введенных чисел.

Console.Write("Введите число: ");
int number;
number = Convert.ToInt32(Console.ReadLine());
int min1 = number;
int min2 = number;
int max1 = number;
int max2 = number;
while (number != 0)
{
    if (number >= max1)
    {
        max2 = max1;
        max1 = number;
    }
    else
    if (max2 < number)
    {
        max2 = number;
    }
    if (number <= min1)
    {
        min2 = min1;
        min1 = number;
    }
    else
    if (min2 > number)
    {
        min2 = number;
    }

    Console.Write("Введите следующее число (0 - для выхода): ");
    number = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("max 1 = " + max1 + "max 2 = " + max2 + "min 1 = " + min1 + "min 2 = " + min2);

