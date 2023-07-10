/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с
наименьшей суммой элементов.                                                                                                                   
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Write("Введите размерность mRows массива: ");
int mRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность nColumns массива: ");
int nColumns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[mRows, nColumns];

void mas(int mRows, int nColumns)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < mRows; i++)
    {
        for (j = 0; j < nColumns; j++)
        {
            array[i,j] = rand.Next(1,9);
        }
    }
}

void print(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }

}

mas(mRows,nColumns);
print(array);
Console.WriteLine();

// нахождение строки с наименьшей суммой элементов 

int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
return sum;
}

int minSum = 1;
int sum = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    if (sum > SumLine(array, i))
    {
        sum = SumLine(array, i);
        minSum = i + 1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");