/*
Программа из массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
*/

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write("\"" + arr[i] + "\", ");
        }
        else if (i == arr.Length - 1)
        {
            Console.Write("\"" + arr[i] + "\"");
        }
    }
    Console.Write("]");
}

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

int SelectiontLingthArr(string[] ARR)
{
    int count = 0;
    for (int i = 0; i < ARR.Length; i++)
    {
        if (ARR[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] SelectiontARRAY(string[] Arr, int size)
{
    string[] SelectArray = new string[size];

    int i = 0;
    for (int j = 0; j < Arr.Length; j++)
    {
        if (Arr[j].Length <= 3)
        {
            SelectArray[i] = Arr[j];
            i++;
        }
    }

    return SelectArray;
}

string[] array1 = { "hello", "2", "world", ":)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[] MyArray = FillArray();
int LengthSelectArray=SelectiontLingthArr(MyArray);
string[] SelectArray = SelectiontARRAY(MyArray, LengthSelectArray);
PrintArray(SelectArray);
Console.WriteLine();
 
int LengthSelectarray1=SelectiontLingthArr(array1);
string[] SelectArray1 = SelectiontARRAY(array1, LengthSelectarray1);
PrintArray(SelectArray1);
Console.WriteLine();

int LengthSelectarray2=SelectiontLingthArr(array2);
string[] SelectArray2 = SelectiontARRAY(array2, LengthSelectarray2);
PrintArray(SelectArray2);
Console.WriteLine();

int LengthSelectarray3=SelectiontLingthArr(array2);
string[] SelectArray3 = SelectiontARRAY(array3, LengthSelectarray3);
PrintArray(SelectArray3);
Console.WriteLine();