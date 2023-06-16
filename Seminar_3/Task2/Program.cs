/* Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).*/


Console.Write("Введите номер четверти от 1 до 4:");
int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1: 
    Console.WriteLine("Диапозон x > 0, y > 0");
    break;

    case 2:
    Console.WriteLine("Диапозон x < 0, y > 0");
    break;

    case 3: 
    Console.WriteLine("Диапозон x < 0, y < 0");
    break;

    case 4:
    Console.WriteLine("Диапозон x > 0, y < 0");
    break;

    default:
    Console.WriteLine("Вы ввели значение не от 1 до 4");
    break;
}
