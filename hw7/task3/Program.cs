// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void FillArray ( int start, int end, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new Random().Next (start, end);
    }
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

void PrintArrayReverse (int[] arr, int index)
{
    if (index < 0 || index >= arr.Length)
    {
        return;
    }
    else 
    {
        Console.Write($"{arr[index]} ");
        PrintArrayReverse (arr, index - 1);
    }
}


int [] user_arr = new int [10];
FillArray (1, 100, user_arr);
PrintArray (user_arr);
System.Console.WriteLine();
PrintArrayReverse(user_arr, user_arr.Length - 1);