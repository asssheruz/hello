// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
	System.Console.WriteLine(message);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int[] InputArray(int length)
{
	int[] array = new int[length];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = Prompt($"Введите {i}-й элемент массива: ");
	}
	return array;
}

void PrintArray(int[] arr)
{
	Console.Write("[");
	for (int i = 0; i < arr.Length; i++)
	{
		if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
		else Console.Write($"{arr[i]}");
	}
	Console.Write("]");
}

int CountPositiveNumbers(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > 0) count++;
	}
	return count;
}

int length = Prompt("Введите количество элементов: ");
int[] array;
array = InputArray(length);
PrintArray(array);
int countPositiveNumbers = CountPositiveNumbers(array);
Console.WriteLine($" --> {countPositiveNumbers}");
