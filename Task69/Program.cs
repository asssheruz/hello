// Задача 69: Напишите программу, которая на вход принимает два 
// числа A и B, и возводит число А в целую степень 
// B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

Console.WriteLine("Введите натуральное число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int multi = NumberDegee(number1, number2);
Console.WriteLine($"{number1} в степене {number2} равно: {multi}");

int NumberDegee(int number1, int number2)
{
	if (number2 == 0) return 1;
	else return checked (number1 * NumberDegee(number1, number2 - 1));
}
