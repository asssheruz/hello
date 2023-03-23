// Задача 69: Напишите программу, которая на вход принимает два 
// числа A и B, и возводит число А в целую степень 
// B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

Console.WriteLine("Введите натуральное число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int NumberDegee(int number1, int number2)
{
	if (number1 == 0) return 1;
	else return checked (number2 * NumberDegee(number1, number1 - 1));
}
int multi = NumberDegee(number1, number2);
Console.WriteLine(multi);
int numberA = Input("Введите целое положительное число A: ");
int numberB = Input("Введите целое положительное число B: ");

int multi = MultiNumbers(numberA, numberB);
Console.Write(multi);

int MultiNumbers(int a, int b)
{
	if (b == 0) return 1;
	else return checked(a * MultiNumbers(a, b - 1));
}

int Input(string text)
{
	Console.Write(text);
	return Convert.ToInt32(Console.ReadLine());
}
