/* Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/


Console.Write("Введите коордитану X :");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Недопустимые координаты: X и Y !=0");
    return; 
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Номер четверти: 1");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("Номер четверти: 2");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("Номер четверти: 3");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("Номер четверти: 4");
}