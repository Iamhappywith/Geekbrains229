/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Write("Введите коордитану X1: ");
int ax = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y1: ");
int ay = int.Parse(Console.ReadLine());

Console.Write("Введите координату Z1: ");
int az = int.Parse(Console.ReadLine());

Console.Write("Введите коордитану X2: ");
int bx = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y2: ");
int by = int.Parse(Console.ReadLine());

Console.Write("Введите координату Z2: ");
int bz = int.Parse(Console.ReadLine());

// l^2 = (x2-x1)^2+(y2-y1)^2+(z2-z1)^2. 

double result = Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2) + Math.Pow((bz - az),2));
Console.WriteLine($"Расстояние между точками равно: {result}");

