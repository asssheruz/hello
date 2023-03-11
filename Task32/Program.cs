// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Console.Write("Введите размер массива: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[arraySize];

// FillArray(array);
// PrintArray(array);
// EditArray(array);
// PrintArray(array);

// void FillArray(int[] arrayValue)
// {
// 	Random rnd = new Random();
// 	for (int i = 0; i < arrayValue.Length; i++)
// 	{
// 		arrayValue[i] = rnd.Next(-10, 10);
// 	}
// }

// void PrintArray(int[] arrayValue)
// {
// 	for (int i = 0; i < arrayValue.Length; i++)
// 	{
// 		if (i != arrayValue.Length - 1) Console.Write($"{arrayValue[i]}, ");
// 		else Console.Write($"{arrayValue[i]}\n");
// 	}
// }

// void EditArray(int[] arrayValue)
// {
// 	for (int i = 0; i < arrayValue.Length; i++)
// 		array[i] *= -1;
// }
int[] CreateArrayRndInt(int size, int min, int max)
{
	int[] arr = new int[size];
	Random rnd = new Random();
	for (int i = 0; i < size; i++)
	{
		arr[i] = rnd.Next(min, max + 1);
	}
	return arr;
}

void PrintArray(int[] arr)
{
	Console.Write("[");
	for (int i = 0; i < arr.Length; i++)
	{
		if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
		else Console.Write($"{arr[i]}");
	}
	Console.WriteLine("]");
}

void ArrayInverse(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = -arr[i];
	}
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
ArrayInverse(array);

PrintArray(array);