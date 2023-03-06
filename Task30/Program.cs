// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8]; // По умольчание массив равно нолю

Array(array);
WriteArray(array);

void Array(int[] arr)
{
	Random rand = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rand.Next(0, 2);
	}
}
void WriteArray(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write(arr[i]);
	}
}
