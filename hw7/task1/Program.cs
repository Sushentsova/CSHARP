// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Введите значения M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

void NatNumbers (int m, int n)
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
    }
        for (int i = start; i <= end; i++)
        {
            System.Console.Write($"{i} ");
        }
}

NatNumbers(m, n);