// Задача 36: Задайте одномерный массив, заполненный
//  случайными числами. Найдите сумму элементов, 
//  стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int[] array = CreateArrayRndInt(4, -10, 10);
int oddNumbersSum = OddNumbersSum(array);
PrintArray(array);
Console.Write($" --> {oddNumbersSum}");


int[] CreateArrayRndInt(int size, int min, int max)
{
	int[] arr = new int[size];
	Random rand = new Random();
	for (int i = 0; i < size; i++)
	{
		arr[i] = rand.Next(min, max + 1);
	}
	return arr;
}

void PrintArray(int[] arr)
{
	Console.Write("[");
	for (int i = 0; i < arr.Length; i++)
	{
		if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
		else Console.Write($"{arr[i]} ");
	}
	Console.Write("]");
}

int OddNumbersSum(int[] arr)
{
	int sum = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (i % 2 != 0) sum += arr[i];
	}
	return sum;
}
