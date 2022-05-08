// 

string [] CreateArray ()
{
    Console.Write ("Введите размер массива ");
    int length = Convert.ToInt32(Console.ReadLine());
    string [] array = new string [length];
    Console.Write ("Введите элементы массива ");
    for (int i = 0; i < length; i++)
    {
        array[i] = ""+Console.ReadLine();
        //Console.WriteLine(array[i] + " ");
    }
    return array;
}

string [] ChoiceArray (string [] array)
{
string [] newArray = new string [array.Length];
int j=0;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray [j] = array[i];
            //Console.Write ("Значения нового массива " + newArray [j] + ", ");
            j++;
        }
    }
    return newArray;
}

void PrintArray(string [] newArray)
{
    Console.Write ("Значения нового массива ");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray [i]}, ");
               
    }
}

string [] array = CreateArray ();
ChoiceArray (array);
PrintArray (array);
