// Задача 34: Задайте массив заполненный случайными
//  положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество 
//  чётных чисел в массиве.

// [345, 897, 568, 234] -> 2 

int[] array = CreateArrayRndInt(8, 100, 999);
PrintArray(array);
int arraySearchEvenNum = ArraySearchEvenNum(array);
Console.WriteLine($"Количество чётных чисел в массиве: {arraySearchEvenNum}");

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
	Console.WriteLine("]");
}

int ArraySearchEvenNum(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 ==0) count++;
	}
	return count;
}