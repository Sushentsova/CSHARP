// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
int[] arr = new int[3];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = number % 10;
    Console.Write($"{arr[i]} ");
    number = number/10;
}

