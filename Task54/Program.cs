// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = InputNumbers("Введите длину строки: ");
int n = InputNumbers("Введите длину столбца: ");
Console.WriteLine();
int[,] array2d = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(array2d);
OrderMatrixLines(array2d);
Console.WriteLine($"\nОтсортированный массив: ");
PrintMatrix(array2d);


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
	int[,] matrix = new int[rows, columns]; 
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

int InputNumbers(string input)
{
	Console.Write(input);
	int output = Convert.ToInt32(Console.ReadLine());
	return output;
}

void OrderMatrixLines(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int k = 0; k < matrix.GetLength(1) - 1; k++)
			{
				if (matrix[i, k] < matrix[i, k + 1])
				{
					int temporary = matrix[i, k];
					matrix[i, k] = matrix[i, k + 1];
					matrix[i, k + 1] = temporary;
				}
			}
		}
	}
}

