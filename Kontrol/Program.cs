//Контрольная работа
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа

string [] CreateArray ()
{
    Console.Write ("Введите размер массива ");
    int length = Convert.ToInt32(Console.ReadLine());
    string [] array = new string [length];
    Console.Write ($"Введите {length} элементов массива ");
    for (int i = 0; i < length; i++)
    {
        array[i] = ""+Console.ReadLine();
    }
    return array;
}

string [] ChoiceArray (string [] array)
{
List<string> newArray = new List<string> ();
for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray.Add(array[i]);
            
        }
    }
    return newArray.ToArray();
}

void PrintArray(string [] newArray)
{
    Console.Write ("Значения нового массива ");
    Console.Write ("[ ");
    for (int i = 0; i < newArray.Length-1; i++)
    {
        Console.Write($"{newArray [i]}, ");     
    }
    Console.Write($"{newArray [newArray.Length-1]}");
    Console.Write (" ]");
}

string [] array = CreateArray ();
string [] newArray = ChoiceArray (array);
PrintArray (newArray);
