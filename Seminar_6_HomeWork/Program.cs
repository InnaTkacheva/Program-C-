// Задача 1: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int Pologit (int M)
// {
//     int count = 0;
//     for (int i = 0; i < M; i++)
//     {
//         Console.Write ("Введите число ");
//         int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 0)
//         {
//         count++;
//         }
//     }
//     return count;
// }
// Console.Write ("Введите запрашиваемое количество чисел ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = Pologit (number);
// Console.Write ("Количество положительных чисел равно " + result);

// Задача 2: 
// Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
// Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

void PrintArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix [i, 0] = 1;
        matrix [i, matrix.GetLength(1)-1] = 1;
    }
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        matrix [0, i] = 1;
        matrix [matrix.GetLength(0)-1, i] = 1;
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix [i,j]} ");
        }
        Console.WriteLine();
    }

}

Console.Write ("Введите количество строк в матрице ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите количество столбцов в матрице ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [row, col];
PrintArray (matrix);