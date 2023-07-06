/*
Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна
3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать
на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] ThreeSymbolsArr(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count += 1;
        }

    }
    string[] result = new string[count];
    if (count == 0)
    {
        string[] array = new string[] { "" };
        return array;
    }

    else
    {
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                result[k] = arr[i];
                k++;
            }
        }
    }
    return result;
}

void PrintArray(string[] arr)
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

string[] array = new string[] { "Russia", "Denmark", "Kazan" };
PrintArray(array);
string[] newArray = ThreeSymbolsArr(array);
Console.WriteLine();
PrintArray(newArray);