/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/ 

/*Console.Write("Введите размерность mRows1 массива: ");
int mRows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность nColumns1 массива: ");
int nColumns1 = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[mRows1, nColumns1];
Console.Write("Введите размерность mRows2 массива: ");
int mRows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность nColumns2 массива: ");
int nColumns2 = Convert.ToInt32(Console.ReadLine());
int[,] arraySecond = new int[mRows2, nColumns2];

void mas(int mRows1, int nColumns1)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < mRows1; i++)
    {
        for (j = 0; j < nColumns1; j++)
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

mas(mRows1,nColumns1);
print(array);
Console.WriteLine();

// Второй массив

void mas2(int mRows2, int nColumns2)
{
    int z, o;
    Random rand = new Random();
    for (z = 0; z < mRows2; z++)
    {
        for (o = 0; o < nColumns2; o++)
        {
            arraySecond[z,o] = rand.Next(1,9);
        }
    }
}

void print2(int[,] arraySecond)
{
    int z, o;
    for (z = 0; z < arraySecond.GetLength(0); z++)
    {
        Console.WriteLine();
        for (o = 0; o < arraySecond.GetLength(1); o++)
        {
            Console.Write($"{arraySecond[z,o]} ");
        }
    Console.WriteLine();
    }

}

mas2(mRows2,nColumns2);
print2(arraySecond);
Console.WriteLine();

// Нахождение произведения двух матриц 

if (nColumns1 != mRows2)
{
    Console.WriteLine("Нельзя умножить матрицы");
}
else
{

}*/
class Program {
  public static void Main (string[] args) {
Console.Write("Введите количество строк 1 массива: ");
int rowsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columnsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int rowsB = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columnsB = int.Parse(Console.ReadLine());
if (columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    return;
}
int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A,B));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
      
    }
return result;
}

void PrintArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        Console.Write($"{inArray[i, j]} ");
    }
Console.WriteLine();
}
}

int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
return arrayC;
}
}
}