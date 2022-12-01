Console.Write("Введите количество элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{

    string[] stringArray = NewStringArrayInput(size);

    
    PrintArray(stringArray);

    System.Console.WriteLine();

    string[] newStringArray = SelectThreeSymbolString(stringArray);

    
    PrintArray(newStringArray);

    
}
else
{
    Console.WriteLine("Ошибка. Колличество элементов не может быть отрицательным.");
}

string[] NewStringArrayInput(int size)
{
    string[] newStringArray = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        newStringArray[i] = Console.ReadLine();
        //Console.WriteLine();
    }

    return newStringArray;
}

void PrintArray(string[] arrayToPrint)
{
    Console.Write("[ ");

    for (int i = 0; i < arrayToPrint.Length - 1; i++)
    {
        Console.Write("\"" + arrayToPrint[i] +"\"" + " , ");
    }

    Console.Write("\"" + arrayToPrint[arrayToPrint.Length - 1] + "\"" + " ]");
    Console.WriteLine();
}

string[] SelectThreeSymbolString(string[] stringArray)
{
    int size = stringArray.Length;
    int newSize = 0;
    int k = 0;
    string[] newStringArray = new string[newSize];

    for (int i = 0; i < size; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newSize++;
            Array.Resize(ref newStringArray, newSize);
            newStringArray[k] = stringArray[i];
            k++;

        }
    }


    return newStringArray;
}