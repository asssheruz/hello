// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7
int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintArray2D(matrix);
Console.WriteLine();
int[] minElemIndexes = MinElemIndexes(matrix);
int[,] newMatrix = DeleteMinRowColumn(matrix, minElemIndexes[0], minElemIndexes[1]);
PrintArray2D(newMatrix);


int[,] DeleteMinRowColumn(int[,] arr2D, int rowDel, int columnDel)
{
	int[,] newArray2D = new int[arr2D.GetLength(0) - 1, arr2D.GetLength(1) - 1];
	int m = 0, n = 0;
	for (int i = 0; i < newArray2D.GetLength(0); i++)
	{
		if (m == rowDel) m++;
		for (int j = 0; j < newArray2D.GetLength(1); j++)
		{
			if (n == columnDel) n++;
			newArray2D[i, j] = arr2D[m, n];
			n++;
		}
		n = 0;
		m++;
	}
	return newArray2D;
}


int[] MinElemIndexes(int[,] arr2D)
{
	int row = 0, column = 0;
	for (int i = 0; i < arr2D.GetLength(0); i++)
	{
		for (int j = 0; j < arr2D.GetLength(1); j++)
		{
			if (arr2D[i, j] < arr2D[row, column])
			{
				row = i;
				column = j;
			}
		}
	}
	return new int[] { row, column };
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
	int[,] arr2D = new int[rows, columns];
	Random rnd = new Random();
	for (int i = 0; i < arr2D.GetLength(0); i++)
	{
		for (int j = 0; j < arr2D.GetLength(1); j++)
		{
			arr2D[i, j] = rnd.Next(min, max + 1);
		}
	}
	return arr2D;
}

void PrintArray2D(int[,] arr2D)
{
	for (int i = 0; i < arr2D.GetLength(0); i++)
	{
		Console.Write("|");
		for (int j = 0; j < arr2D.GetLength(1); j++)
		{
			Console.Write($"{arr2D[i, j],5} ");
		}
		Console.WriteLine("|");
	}

}
