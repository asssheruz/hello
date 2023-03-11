// Задача 19.
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;
namespace LosicalPrograms
{
	class LosicalPrograms
	{
		static void Main(string[] args)
		{
			int num, temp, revNum = 0, ren;
			Console.Write("Введите натуральное пятизначное число: ");
			num = Convert.ToInt32(Console.ReadLine());

			temp = num;
			while (num > 0)
			{
				ren = num % 10;
				revNum = revNum * 10 + ren;
				num = num / 10;
			}
			if (revNum == temp)
				Console.WriteLine("Введенное число является полиндромом.");
			else
				Console.WriteLine("Число не является полиндромом.");
		}
	}
}
