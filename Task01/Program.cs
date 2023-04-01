// Задача: 
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] array = CreateArray(4);
PrintArray(array);
Console.Write(" -> ");
SortArray(array);
string[] array2 = NewArray2(array);
PrintArray(array2);


string[] CreateArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите элемент массива");
        string element = Console.ReadLine();
        arr[i] = element;
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},  ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


void SortArray(string[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        int c = j;
        for (int i = j + 1; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3) c = i;
        }
        string temp = arr[j];
        arr[j] = arr[c];
        arr[c] = temp;
    }
}

string[] NewArray2(string[] arr)
{
    int sizeofnewarray = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) sizeofnewarray = sizeofnewarray + 1;
    }

    string[] newarray2 = new string[sizeofnewarray];
    for (int j = 0; j < sizeofnewarray; j++)
        newarray2[j] = arr[j];

    return newarray2;
}