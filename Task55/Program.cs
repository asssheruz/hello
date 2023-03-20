// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int rowMatrix = Input("Введите кол-во строк в массиве m: ");
int colMatrix = Input("Введите кол-во столбцов в массиве n: ");

int[,] matrixNew = CreateMatrixRndInt(rowMatrix, colMatrix, 10, 70);
PrintMatrix(matrixNew);
PermutationRowAndCol(matrixNew);
PrintMatrix(matrixNew);

void PermutationRowAndCol(int[,] matrix1)
{
	for (int i = 0; i < matrix1.GetLength(0) - 1; i++)
	{
		for (int j = i + 1; j < matrix1.GetLength(1); j++)
		{
			int value = matrix1[i, j];
			matrix1[i, j] = matrix1[j, i];
			matrix1[j, i] = value;
		}
	}
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
	int[,] matrix = new int[rows, columns];

	Random rnd = new Random(); // создаем экземпляр класса вне цикла

	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rnd.Next(min, max + 1);
		}
	}
	return matrix;
}

int Input(string text)
{
	Console.Write(text);
	return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("|");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j],5}");
		}
		Console.WriteLine("|");
	}
	Console.WriteLine("");
}