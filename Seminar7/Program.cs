// Задача 1:
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// void Array (int m, int n)
// {
//     Random r = new Random();
//     int [,] matrix = new int [m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix [i, j] = r.Next (10, 100);
//             Console.Write ($"{matrix [i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int dlinaRow = 3;
// int dlinaCol = 4;
// Array (dlinaRow, dlinaCol);

// Задача 2: 
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

// void Array (int m, int n)
// {
//     int [,] matrix = new int [m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix [i, j] = i+j;
//             Console.Write ($"{matrix [i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int dlinaRow = 3;
// int dlinaCol = 4;
// Array (dlinaRow, dlinaCol);

// Задача 3: 
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// void Array (int m, int n)
// {
//     int [,] matrix = new int [m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix [i, j] = new Random().Next (2, 10);
//             Console.Write ($"{matrix [i,j]} ");
//         }
//         Console.WriteLine();
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i%2 == 0 && j%2 == 0)
//             {
//                 matrix [i, j] = matrix [i, j] * matrix [i, j];
//             }
//             Console.Write ($"{matrix [i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int dlinaRow = 3;
// int dlinaCol = 4;
// Array (dlinaRow, dlinaCol);

// Задача 4: 
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.

void Array (int m)
{
    int sum = 0;
    int [,] matrix = new int [m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix [i, j] = new Random().Next (1, 10);
            if (i == j) sum = sum + matrix [i, j];
            Console.Write ($"{matrix [i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(sum);
}
int dlina = 3;

Array (dlina);