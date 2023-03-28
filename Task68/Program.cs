// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

Console.WriteLine("Введите целое положительное число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число n:");
int n = Convert.ToInt32(Console.ReadLine());

int functionsAkkerman = FunctionsAkkerman(m, n);
Console.WriteLine($" A ({m}, {n}) = {functionsAkkerman}");

int FunctionsAkkerman(int m, int n)
{
	if (m == 0) return n+1;
	else if (n == 0) return FunctionsAkkerman(m - 1, 1);
	else return FunctionsAkkerman(m - 1, FunctionsAkkerman(m, n-1)); 	
}

