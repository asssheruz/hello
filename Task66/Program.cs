// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число М");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N");
int n = Convert.ToInt32(Console.ReadLine());

int sumOfElements = SumOfElements(m, n);
Console.WriteLine(sumOfElements);

int SumOfElements(int m, int n)
{
	if (m == n) return m;
	if (m > n) return SumOfElements(m - 1, n) + m;
	else return SumOfElements(m + 1, n) + m;
}
