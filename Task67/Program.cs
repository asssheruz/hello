// Задача 67: Напишите программу, которая будет принимать на 
// вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите цeлое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumAllDigit = SumAllDigit(number);
Console.Write($" Cумму его цифр: {sumAllDigit}");

int SumAllDigit(int num)
{
	int result = 0;
	while (num > 0)
	{
		result += num % 10;
		num = num / 10;
		SumAllDigit(num - 1);
	}
	return result;
}

Console.WriteLine("Введите цeлое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = SumNumbersDigits(number);
Console.Write(num);

int SumNumbersDigits(int n)
{
	if (n == 0) return 0;
	else return n % 10 + SumNumbersDigits(n / 10);
}

