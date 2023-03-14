// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(5, -50, 50);
PrintArrayDouble(array);
double arraySearchMax = ArraySearchMax(array);
double arraySearchMin = ArraySearchMin(array);
double arrayResult = ArrayResult(array);
Console.WriteLine($"Максимальное элемент массива: {arraySearchMax}");
Console.WriteLine($"Минимальное элемент массива: {arraySearchMin}");
Console.WriteLine($"Разница между максимальным и минимальным элементам массива равно {arrayResult}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
	double[] arr = new double[size];
	Random rnd = new Random();
	for (int i = 0; i < size; i++)
	{
		double num = rnd.NextDouble() * (max - min) + min;
		arr[i] = Math.Round(num, 1);
	}
	return arr;
}

void PrintArrayDouble(double[] arr)
{
	Console.Write("[");
	for (int i = 0; i < arr.Length; i++)
	{
		if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
		else Console.Write($"{arr[i]}");
	}
	Console.WriteLine("]");
}

double ArraySearchMax(double[] arr)
{
	double maxNumber = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] > maxNumber) maxNumber = arr[i];
	}
	return maxNumber;
}

double ArraySearchMin(double[] arr)
{
	double minNumber = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] < minNumber) minNumber = arr[i];
	}
	return minNumber;
}

double ArrayResult(double[] arr)
{
	double result = arraySearchMax - arraySearchMin;
	result = Math.Round(result, 1);
	return result;
}

