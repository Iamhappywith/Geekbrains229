/*Напишите программу, которая будет принимать на фход число и возвращать сумму его цифр */

Console.Write("Input integer: ");
int number = int.Parse(Console.ReadLine());

int SumRecIntegers(int number)
{
    if (number == 0) return 0;
    int temp = number % 10 + SumRecIntegers(number / 10);
    return temp;   
} 

Console.WriteLine(SumRecIntegers(number));