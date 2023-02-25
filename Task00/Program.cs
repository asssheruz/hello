// Напишите программу, которая
// 1. На вход принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Введите целое число: ");
// string str = Console.ReadLine();

int number = Convert.ToInt32(Console.Readline());
int square = number * number;
Console.WriteLine(square);