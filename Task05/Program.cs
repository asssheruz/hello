﻿// 5.Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
	for (int i = -number; i <= number; i++)
	{
		Console.WriteLine(i + " ");
	}
}
else
{
	Console.WriteLine("Должно быть положительное целое число");
}
