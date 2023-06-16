/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве*/

Console.WriteLine("Введите значение координаты x1: ");
int ax = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты y1: ");
int ay = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты x2: ");
int bx = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты y2: ");
int by = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2));
Console.WriteLine($"Расстояние между точками равно: {result}");