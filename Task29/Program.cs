// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int Prompt(string massage)
{
	Console.Write(massage);
	string ReadInput = Console.ReadLine();
	int result = int.Parse(ReadInput);
	return result;
}

int [] GenerateArray(int Length, int minValue, int maxValue)
{
	int[] array = new int[Length];
	Random random = new Random();
	for (int i = 0; i < Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}
	return array;
}

void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length - 1; i++)
	{
		Console.Write($"{array[i]}, ");
	}
	Console.Write($"{array[array.Length - 1]}");
	Console.Write("]");
}
void FillArray(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		Console.Write($"{array[i]}, ");
	}
	Console.Write($"{array[array.Length - 1]}");
	Console.Write(" -> ");
}

int Length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение массива: ");
int max = Prompt("Конечное значенеи массива: ");
int[] array = GenerateArray(Length, min, max);

FillArray(array); PrintArray(array);