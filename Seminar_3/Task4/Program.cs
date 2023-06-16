/*Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу квадратов чисел от 1 до N.*/

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int result = 0; 
for (int i = 1; i <= a; i++)
{
    result = i * i; 
    Console.Write($"{result} ");
}