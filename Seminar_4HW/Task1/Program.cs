/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите число A: ");
double a = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
double b = int.Parse(Console.ReadLine());

if (b < 1)
Console.Write("Число B должно быть натуральным");
else
{
double result = Math.Pow(( a ),b );
Console.Write($"Число A в натуральной степени B равно {result}");
}