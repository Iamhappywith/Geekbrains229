/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.*/

int[] array = {6, 7, 19, 345, 3};

Console.WriteLine("Впишите число: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < array.Length; i++)

{
    if (array[i] == num)
    {
        Console.WriteLine("Есть совпадение");
        
    }
    else if (array[i] != num)
    {
    Console.WriteLine("Cовпадений не выявлено");
    }
}



