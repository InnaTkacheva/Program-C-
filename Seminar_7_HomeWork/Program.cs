// Задача 1. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void Array (int m, int n)
// {
//     double [,] matrix = new double [m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix [i, j] = (new Random().NextDouble()-0.5) * 10;
//             Console.Write ("{0:0.#} ", matrix [i, j]); //$"{matrix [i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int dlinaRow = 3;
// int dlinaCol = 4;
// Array (dlinaRow, dlinaCol);


// Задача 2. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// void Array (int m, int n)
// {
//     int [,] matrix = new int [m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix [i, j] = new Random().Next (-10, 10);
//             Console.Write ($"{matrix [i,j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.Write ("Введите строку искомого элемента в матрице ");
//     int row1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write ("Введите столбец искомого элемента в матрице ");
//     int col1 = Convert.ToInt32(Console.ReadLine());
    
//     if (row1 < 0 || col1 < 0 || row1 >= m || col1 >= n)
//     {
//         Console.Write ("Такого элемента не существует в матрице ");
//     }
//     else
//     {
//         Console.Write ($"{matrix [row1,col1]} ");
//     }
        
//     Console.WriteLine();
    
// }
// int dlinaRow = 3;
// int dlinaCol = 4;
// Array (dlinaRow, dlinaCol);



// Задача 3. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Array (int m, int n)
{
    int [,] matrix = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix [i, j] = new Random().Next (-10, 10);
            Console.Write ($"{matrix [i,j]} ");
        }
        Console.WriteLine();
    }
    
    for (int i = 0; i < n; i++)
    {
        double sumSred = 0;
        for (int j = 0; j < m; j++)
        {
            sumSred = matrix [j,i] + sumSred;
        }
        Console.Write("{0:0.#} ", sumSred/m);
        
    }
    Console.WriteLine();
    
}
int dlinaRow = 3;
int dlinaCol = 4;
Array (dlinaRow, dlinaCol);
