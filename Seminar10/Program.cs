// Задача 1:
// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих.

int Fibonachi (int startNum1, int startNum2, int size)
{
    if (size == 1) return startNum1;
    if (size == 2) return startNum2;
    else return Fibonachi (startNum1, startNum2, size-1) + Fibonachi (startNum1, startNum2, size-2);
}
int num1 = 0;
int num2 = 1;
int col = 5;

for (int i = 1; i <= col; i++)
{
    Console.Write(Fibonachi (num1, num2, i) + " ");
}

// Задача 2:
// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

void PrintWords (string alf, int lengthWord, string currentWord) 
{
    if (lengthWord == 0) Console.WriteLine (currentWord);
    else 
    {
        for (int i = 0; i < alf.Length; i++)
        {
            PrintWords (alf, lengthWord-1, currentWord+alf[i]);
        }
    }
}

PrintWords ("ABC", 3, "");

// 2
// aa
// ab
// ас
// ba
// bb
// bc
// ca
// cb
// cc

// 3
// aaa
// aab
// aac
// aba

// 4



// Задача 3:
// 