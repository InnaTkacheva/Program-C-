/*
//Задача 1:

Console.Write("Введите целое число: ");
int value = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value*value;

Console.Write("Квадрат данного числа равен ");
Console.WriteLine(kvadrat_value);


//Задача 2:

Console.Write("Введите первое целое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите проверочное целое число: ");
int value2 = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value1*value1;

if (value2 == kvadrat_value)
{
    Console.Write("Квадрат числа равен проверочному");
}
else 
{
    Console.WriteLine("Квадрат числа не равен проверочному");
}
*/

//Задача 3:

Console.Write("Введите Ваше номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7)
{
Console.Write("Такого дня недели не существует");
}
else
{
if (day == 7)
{
    Console.Write("Воскресенье");
}
if (day == 6)
{
    Console.Write("Суббота");
}
if (day == 5)
{
    Console.Write("Пятница");
}
if (day == 4)
{
    Console.Write("Четверг");
}
if (day == 3)
{
    Console.Write("Среда");
}
if (day == 2)
{
    Console.Write("Вторник");
}
if (day == 1)
{
    Console.Write("Понедельник");
}
}


