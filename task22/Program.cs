// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые делятся нацело на 7

void FillArray ( int[] arr)
{
    System.Console.WriteLine("Заполните массив");
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void printArray(int[] arrayToPrint)
{
Console.Write("[");
for (int i = 0; i < arrayToPrint.Length; i++)
{
Console.Write(arrayToPrint[i]);
if (i != arrayToPrint.Length - 1)
{
Console.Write(", ");
}
}
Console.Write("]");
Console.WriteLine();
}

int CountEven (int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0)
        {result++;}
    }
    return result;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] user_arr = new int [size];
FillArray(user_arr);
printArray(user_arr);
System.Console.WriteLine(CountEven(user_arr));