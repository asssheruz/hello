// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void ReplaceFirstLastRows(int[,] matrix)
{
	int firstRowsIndex = 0;
	int lastRowsIndex = matrix.GetLength(0) - 1;
	for (int i = 0; i < matrix.GetLength(1); i++)
	{
		int temp = matrix[firstRowsIndex, i];
		matrix[firstRowsIndex, i] = matrix[lastRowsIndex, i];
		matrix[lastRowsIndex, i] = temp;
	}
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
ReplaceFirstLastRows(array2d);
Console.WriteLine();
PrintMatrix(array2d);