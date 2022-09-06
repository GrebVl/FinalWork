/*
Программа из массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
*/

string[] FillArray()
{

    Console.WriteLine("Заполнити массив через запятую c пробелом:");
    Console.WriteLine("пример: 12, 1234, ghfh fhg");
    string[] input = Console.ReadLine().Split(", ");
    string[] ARRAY = new string[input.Length];

    for (int j = 0; j < input.Length; j++)
    {
        ARRAY[j] = input[j];
    }

    return ARRAY;
}

void PrintSelectionArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Console.Write("\"" + arr[i] + "\", ");
        }
    }
    Console.Write("]");
}

string[] array = { "hello", "2", "world", ":)" };
string[] array1 = { "1234", "1567", "-2", "computer science" };
string[] array2 = { "Russia", "Denmark", "Kazan" };

string[] MyArray = FillArray();
PrintSelectionArray(MyArray);
Console.WriteLine();

PrintSelectionArray(array);
Console.WriteLine();


PrintSelectionArray(array1);
Console.WriteLine();


PrintSelectionArray(array2);
Console.WriteLine();