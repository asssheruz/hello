// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число М");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbersDigits(m, n);
Console.Write(sum);

int SumNumbersDigits(int m, int n)
{
	sum = 0;
	if (m < n)
	{
		sum += m;
		SumNumbersDigits(m + 1, n);
		return sum;
	}
	else if (m > n)
	{
		sum += m;
		SumNumbersDigits(m - 1, n);
		return sum;
	}
	else return sum = m + n;
}
