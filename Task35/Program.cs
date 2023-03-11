// Задача 35: Задайте одномерный массив из 123 
// случайных чисел. Найдите количество элементов 
// массива, значения которых лежат в отрезке [10,99].
//  Пример для массива из 5, а не 123 элементов. 
//  В своём решении сделайте для 123 
//  [5, 18, 123, 6, 2]  -> 1
//  [1, 2, 3, 6, 2] -> 0
//  [10, 11, 12, 13, 14]-> 5

int[] array = CreateArrayRndInt(123, -150, 150);
PrintArray(array);
int arraySearch = ArraySearch(array);
Console.WriteLine($"Количество двузначных элементов массива равно {arraySearch}");

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

int ArraySearch(int[] arrayValue)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] >= 10 && array[i] <= 99) count++;
	}
	return count;
}