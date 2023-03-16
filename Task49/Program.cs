// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
		Console.WriteLine("|");
	}
}

void MatrixIndex(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (i % 2 == 0 && j % 2 == 0)
			{
				matrix[i, j] *= matrix[i, j];
			}
		}
	}
}

void MatrixIndex2(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i += 2)
	{
		for (int j = 0; j < matrix.GetLength(1); j += 2)
		{
			matrix[i, j] *= matrix[i, j];
		}
	}
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 20);
PrintMatrix(array2d);
Console.WriteLine();
MatrixIndex2(array2d);
PrintMatrix(array2d);
