// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 - > {number}");
// int firstDigit = number / 100;
// int thirdDigit = number % 10;

// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"Результат - > {result}");

int delSecondDigit = DelSecondDigit(number);
Console.WriteLine($"Полученное двухзначное число -> {delSecondDigit}");

int DelSecondDigit(int num)
{
	int firstDigit = num / 100;
	int lastDigit = num % 10;
	int sumD = firstDigit * 10 + lastDigit;
	return sumD;
}