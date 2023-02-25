// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.WriteLine("введите число a");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
	Console.WriteLine("да");
}
else
{
	Console.WriteLine("нет");
}