// Задача 52.Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3.

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
double getAverageByColumn = GetAverageByColumn(avrgByColumns);
Console.WriteLine($"Среднее арифметическое каждого столбца: {getAverageByColumn}");

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

double[] GetAverageByColumn(int[,] arrayToGetAverage)
{
	double[] avrgByColumns = new double [arrayToGetAverage.GetLength(1)];
	for (int i = 0; i < arrayToGetAverage.GetLength(0); i++)
	{
		for (int j = 0; j < arrayToGetAverage.GetLength(1); j++)
		{
			avrgByColumns[j] += Convert.ToDouble(arrayToGetAverage[i, j]);
			}
	}
	for (int i = 0; i < avrgByColumns.Length; i++)
	{
		avrgByColumns[i] /= arrayToGetAverage.GetLength(0);
	}
	return avrgByColumns;
}


