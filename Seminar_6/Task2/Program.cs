/* Задача 40: Напишите программу, которая принимает на
 вход три числа и проверяет, может ли существовать 
 треугольник с сторонами такой длины.*/

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());

if(a+b>c && a+c>b && b+c>a)
{
    Console.WriteLine("Треугольник существует");
}
else
{
        Console.WriteLine("Треугольник не существует");
}
