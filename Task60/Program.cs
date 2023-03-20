


int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
	int[,,] matrix = new int[rows, columns, depth]; // 0, 1

	Random rnd = new Random();

	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int k = 0; k < matrix.GetLength(2); k++)
			{
				matrix[i, j, k] = rnd.Next(min, max + 1);
			}
		}
	}
	return matrix;
}