/* 
Напишите программу, которая на вход
принимает число и выдает его квадрат (число умноженное на само себя)ю

4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;

Console.WriteLine(result);