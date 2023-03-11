// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A 
// в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

Console.WriteLine("Введите натуральное число А: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

int NumberDegee(int number_1, int number_2)
{
	int result = 1;
	for (int i = 0; i < number_2; i++)
	{
		result *= number_1;
	}
	return result;
}

bool ValidateNumber_2(int number_2)
{
	if (number_2 < 0)
	{
		Console.WriteLine("Cтепень числа должна быть не меньше нуля");
		return false;
	}
	return true;
}

if (ValidateNumber_2(number_2))
{
	Console.WriteLine($"Число {number_1} в степени {number_2} равно {NumberDegee(number_1, number_2)}");
}
