/* Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].*/

int[] array = new int[123];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int number = 0;

for(int i = 0; i < array.Length; i++)
{
    if( array[i] > 9 && array[i] < 100)
    {
        number = number + 1;
    }
}
Console.WriteLine($"кол.во эллементов массива от 10 до 99 = {number} ");
