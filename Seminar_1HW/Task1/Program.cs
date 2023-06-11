/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */


Console.WriteLine("Введите первое целое число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int number_2 = int.Parse(Console.ReadLine());

if (number > number_2)
{
    Console.WriteLine("Первое число является большим, а второе меньшим");
}
else
{
    Console.WriteLine("Второе число является большим, а второе меньшим");
}
