/*
Программа из массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
*/
string[] array = { "hello", "2", "world", ":)" };

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Console.Write(arr[i] + ", ");
        }
    }
}

PrintArray(array);