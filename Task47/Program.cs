// Задача 47.Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 	7 	-2 	-0,2
// 1 	-3,3 	8 	-9,9
// 8 	7,8 	-7,1 	9

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
	double[,] matrix = new double[rows, columns]; //0, 1

	Random rand = new Random();

	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			double num = rand.NextDouble() * (max - min) + min;
			matrix[i, j] = Math.Round(num, 1); 
		}
	}
	return matrix;
}

void PrintArrayDouble(double[,] matrix)
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

double[,] array2d = CreateMatrixRndDouble(3, 4, -10, 10);
PrintArrayDouble(array2d);
