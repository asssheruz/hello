// Задача 40: Напишите программу, которая принимает 
// на вход три числа и проверяет, может ли существовать
//  треугольник с сторонами такой длины. Теорема о 
//  неравенстве треугольника: каждая сторона 
//  треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int numC = Convert.ToInt32(Console.ReadLine());

bool TriangleCheck(int a, int b, int c)
{
	return a + b > c && a + c > b && c + b > a;
}

Console.WriteLine(TriangleCheck(numA, numB, numC) ? "Да" : "Нет");