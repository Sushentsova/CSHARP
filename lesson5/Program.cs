//Двумерные массивы

int[,] Fill2Array(int row, int colum)
{
    Random rnd = new Random();
    int[,] arr = new int[row,colum];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(1,11);
        }
    }
    return arr;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[]\t");
    const int startIndex = 0;
    for (int i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
       Console.Write($"[{(i)}]\t"); 
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t"); 

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


// Задайте двументый массив. 
// Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.

void Print2DArrayChet(int[,] arrayToPrint)
{
    Console.Write($"[]\t");
    const int startIndex = 0;
    for (int i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
       Console.Write($"[{(i)}]\t"); 
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t"); 

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
            Console.Write(Convert.ToInt32(Math.Pow(arrayToPrint[i,j],2))+"\t");
            }
            else
            {
            Console.Write(arrayToPrint[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}


int[,] arr = Fill2Array(3,5);
Print2DArray(arr);
System.Console.WriteLine();
Print2DArrayChet(arr);

// Задайте двумерный массивю Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.)

int SumDiagonal (int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {sum = sum + arr[i,j];}
        } 
    }
    return sum;
}

int sum = SumDiagonal(arr);
System.Console.WriteLine(sum);

// Задайте двумерный массив из целых чисел. 
// Сформируйте новый одномерный массив, 
// состоящий из средних арифметических значений 
// по строкам двумерного массива.


