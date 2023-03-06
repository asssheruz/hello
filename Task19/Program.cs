// Задача 19.
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number > 9999 && number < 100000)
{
	int result = number % 10;
	Console.WriteLine(result);
}
else
{
	Console.WriteLine("Нужно ввести пятизначное число");
}