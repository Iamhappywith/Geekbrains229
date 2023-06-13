// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число : {number}");

int firstDigit = number / 100;
int secondDigit = firstDigit / 10;
int thirdDigit = number % 10; 
int result = firstDigit * 10 + thirdDigit;

Console.WriteLine(result);


/*
var string = thirdDigit.ToString();

thirdDigit = int.Parse(str.Remove(str.Length - 1, 1));

Console.WriteLine(thirdDigit);*/