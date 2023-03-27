// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


int m = InputNumbers("Введите длину строки: ");
int n = InputNumbers("Введите длину столбца: ");
Console.WriteLine();
int[,] array = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
	int tempSumLine = SumLineElements(array, i);
	if (sumLine > tempSumLine)
	{
		sumLine = tempSumLine;
		minSumLine = i;
	}
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой элементов");

int SumLineElements(int[,] array, int i)
{
	int sumLine = array[i, 0];
	for (int j = 1; j < array.GetLength(1); j++)
	{
		sumLine += array[i, j];
	}
	return sumLine;
}

int InputNumbers(string input)
{
	Console.Write(input);
	int output = Convert.ToInt32(Console.ReadLine());
	return output;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
	int[,] matrix = new int[rows, columns]; //0, 1
	Random rand = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rand.Next(min, max + 1);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("|");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j],5} ");
		}
		Console.WriteLine(" |");
	}
}
