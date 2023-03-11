// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumAllDigit = SumAllDigit(number);
// Console.WriteLine($"Сумма всех чисел в цифре {number} = {sumAllDigit}");
int SumAllDigit(int number)
{
	int result = 0;
	while (number > 0)
	{
		result += number % 10;
		number = number / 10;
	}
	return result;
}

bool ValidateNumber(int number)
{
	if (number < 0)
	{
		Console.WriteLine("Введено некорректное число.");
		return false;
	}
	return true;
}

if (ValidateNumber(number))
{
	Console.WriteLine($"Сумма всех чисел в цифре {number} = {sumAllDigit}");
}