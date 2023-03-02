// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
Console.Write("Четверть ");
int number = Convert.ToInt32(Console.ReadLine());
string cord = Cord(number);
string result = cord != "ERROR"
				? $"Указанные черверть соответствуют координатам - {cord}"
				: "Введена некоррекная четверть";
Console.WriteLine(result);

string Cord(int num)
{
	if (num == 1) return "x > 0 && y > 0";
	if (num == 2) return "x < 0 && y > 0";
	if (num == 3) return "x < 0 && y < 0";
	if (num == 4) return "x > 0 && y < 0";
	return "ERROR";
}