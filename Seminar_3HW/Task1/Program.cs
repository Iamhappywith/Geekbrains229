/* Задача 19
Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (Math.Abs(number) < 1000 || Math.Abs(number) > 99999)
{
    Console.WriteLine("Ваше число не палидром");
    Environment.Exit(0);
}

string number_str = number.ToString();

if (number_str[0] == number_str[4] && 
    number_str[1] == number_str[3])
{
    Console.WriteLine("Ваше число палидром");
}
else
{
    Console.WriteLine("Ваше число не палидром"); 
}
