/*
Программа из массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
*/
string[] array = { "hello", "2", "world", ":)" };

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            if (i < arr.Length - 1)
            {
                Console.Write("\"" + arr[i] + "\", ");
            }
            else if (i == arr.Length - 1)
            {
                Console.Write("\"" + arr[i] + "\"]");
            }
        }

    }
}

string[] FillArray(int num)
{
    string[] ARRAY = new string[num];

    Console.WriteLine("Заполнити массив через пробел");
    string[] input = Console.ReadLine().Split();
    for (int j = 0; j < ARRAY.Length; j++)
    {
        ARRAY[j] = input[j];
    }

    return ARRAY;
}

Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());

string[] MyArray = FillArray(size);
PrintArray(MyArray);
Console.WriteLine();
PrintArray(array);