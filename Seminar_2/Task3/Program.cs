﻿/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */

Console.WriteLine("Введите 1 число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");
int number2 = int.Parse(Console.ReadLine());

if ((number % number2) == 0)
{
    Console.WriteLine("2 Число кратно 1");
}
else 
{
    Console.WriteLine("2 Число не кратно 1");
}