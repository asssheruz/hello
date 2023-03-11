// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
	int factorialNumbers = FactorialNumbers(number); 
	Console.WriteLine($"Факториал чисел от 1 до {number} = {factorialNumbers}");
}
else
{
	Console.WriteLine("Введите число больше нуля");
}

int FactorialNumbers(int num) 
{
	int sum = 1;
	for (int i = 1; i <= num; i++)
	{
		checked
		{
			sum *= i; // sum = sum * i;
		}
	}
	return sum; // 28
}
