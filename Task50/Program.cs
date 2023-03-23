// Задача 50.Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же 
// указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7->такого элемента в массиве нет

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine("Введите значение: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
FrindElementMatrix(array2d, usernumber);

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

void FrindElementMatrix(int[,] frindelement, int usernumber)
{
	bool frind = false;
	for (int i = 0; i < frindelement.GetLength(0); i++)
	{
		for (int j = 0; j < frindelement.GetLength(1); j++)
		{
			if (frindelement[i, j] == usernumber)
			{
				Console.WriteLine("Ваше значение находится по координатам: " + i + " " + j);
				frind = true;
			}
		}
	}
	if (!frind)
		Console.WriteLine("Такое значение в массиве нет.");
}