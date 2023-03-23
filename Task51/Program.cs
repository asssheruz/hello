// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int DiagonalMatrixSumV1(int[,] matrix)
{
	int sum = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (j == i)
			{
				sum += matrix[i, j];
			}
		}
	}
	return sum;
}
int DiagonalMatrixSumV2(int[,] matrix)
{
	int sum = 0;
	int i = 0;
	int j = 0;
	while (i < matrix.GetLength(0) && j < matrix.GetLength(1))
	{
		if (i == j)
		{
			sum += matrix[i, j];
		}
		i++;
		j++;
	}
	return sum;
}

int[,] array2d = CreateMatrixRndInt(4, 3, 0, 10);
PrintMatrix(array2d);
int diagonalMatrixSumV1 = DiagonalMatrixSumV1(array2d);
Console.WriteLine($"Сумма элементов массива по главной диагонали вариант 1: {diagonalMatrixSumV1}");
int diagonalMatrixSumV2 = DiagonalMatrixSumV2(array2d);
Console.WriteLine($"Сумма элементов массива по главной диагонали вариант 2: {diagonalMatrixSumV2}");
