/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/ 

Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 && number > 7)
{
    Console.WriteLine("Вы ввели неверное число!");
}
else if (number > 5)
{
    Console.WriteLine("Этот день выходной!");
}
else
{
    Console.WriteLine("Это не рабочий день!");
}