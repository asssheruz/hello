// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 		 0  1			  0  1
// 
// 0   2  4 	| 	3  4
// 1   3  2 	| 	3  3
// Результирующая матрица будет:
// 18 20
// 15 18

// 2*3 + 4*3 = 18 	 2*4 + 4*3 = 20 
// 3*3 + 2*3 = 15    3*4 + 2*3 = 18
// matrix[0,0]*array2d[0,0] + matrix[0,1]*array2d[1,0]
// matrix[0,0]*array2d[0,1] + matrix[0,1]*array2d[1,1]
// matrix[1,0]*array2d[0,0] + matrix[1,1]*array2d[1,0]
// matrix[1,0]*array2d[0,1] + matrix[1,1]*array2d[1,1]


int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");

int[,] firstMartrix = CreateMatrixRndInt(m, n, 1, 10);
Console.WriteLine($"\nПервая матрица:");
PrintMatrix(firstMartrix);

int[,] secomdMartrix = CreateMatrixRndInt(n, p, 1, 10);
Console.WriteLine($"\nВторая матрица:");
PrintMatrix(secomdMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintMatrix(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
	for (int i = 0; i < resultMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < resultMatrix.GetLength(1); j++)
		{
			int sum = 0;
			for (int k = 0; k < firstMartrix.GetLength(1); k++)
			{
				sum += firstMartrix[i, k] * secomdMartrix[k, j];
			}
			resultMatrix[i, j] = sum;
		}
	}
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
