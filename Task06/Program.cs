// Задача 6: Напишите программу, которая на 
// вход принимает число и выдаёт, является ли 
// число чётным (делится ли оно на два без остатка).

// 4->да
// - 3->нет
// 7->нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
if (number % 2 == 1)
{
	Console.WriteLine(number + " является чётным числом.");
}
else
{
	Console.WriteLine("нет");
}