// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.


// Случайное число от 10 до 99 (включительно)
int number = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число : {number}");

int firstDigit - number / 10; 
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра в числе: {firstDigit}");
}
else
{
    Console.WriteLine($"Наибольшая цифра в числе: {secondDigit}");
}