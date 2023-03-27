// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число М");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N");
int b = Convert.ToInt32(Console.ReadLine());

// int sumNumbersDigits = SumNumbersDigits(m, n);
// Console.WriteLine(sumNumbersDigits);

// int SumNumbersDigits(int m, int n)
// {
// 	if (m < n || m > n)
// 	{
// 		return m + SumNumbersDigits(m + 1, n);
// 	}
// 	else return m + n;
// }

int recursMetod = RecursMetod(a, b);
Console.WriteLine(recursMetod);

int RecursMetod(int a, int b)
{
	int sum = 0;
	if (a <= b)
	{
		sum += a;
		RecursMetod(a + 1, b);
	}
	return sum;
}