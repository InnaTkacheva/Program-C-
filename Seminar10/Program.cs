// Задача 1:
// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих.

// int Fibonachi (int startNum1, int startNum2, int size)
// {
//     if (size == 1) return startNum1;
//     if (size == 2) return startNum2;
//     else return Fibonachi (startNum1, startNum2, size-1) + Fibonachi (startNum1, startNum2, size-2);
// }
// int num1 = 0;
// int num2 = 1;
// int col = 5;

// for (int i = 1; i <= col; i++)
// {
//     Console.Write(Fibonachi (num1, num2, i) + " ");
// }

// Задача 2:
// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

// void PrintWords (string alf, int lengthWord, string currentWord) 
// {
//     if (lengthWord == 0) Console.WriteLine (currentWord);
//     else 
//     {
//         for (int i = 0; i < alf.Length; i++)
//         {
//             PrintWords (alf, lengthWord-1, currentWord+alf[i]);
//         }
//     }
// }

// PrintWords ("ABC", 3, "");


// Задача 3:
// Напишите программу
// data {0, 1, 1, 1, 1, 0, 0, 0, 1} j смещает от начала массива количество элементов чтобы взять следующий элемент согласно info [i]
// info {2, 3, 3, 1}
// array {1, 7, 0, 1}

int [] ExtractData (int [] data, int [] info)
{
    int [] array = new int [info.Length];
    int j = 0;
    for (int i = 0; i < info.Length; i++)
    {
        for (int k = 0; k < info[i]; k++)
        {
           array[i] = array[i] + data[j]*(int)Math.Pow(2,info[i]-k-1);
           j++;
        } 
    }
    return array;
}

void PrintExtractData (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

int [] data1 = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int [] info1 = {2, 3, 3, 1};
int [] array1 = ExtractData (data1, info1);
PrintExtractData (array1);
