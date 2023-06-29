/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

/*Console.Write("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine());
int[] randomArray = new int[a];

for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(100,1000);
Console.Write(randomArray[i] + " ");
}
                                             
for (int count = 0; count < a;)
{ 
    a[i] = int.Parse(Console.ReadLine());
    if (a[i] % 2 == 0)
    count++;
}
Console.Write(count);*/

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(100,1000);
Console.Write(randomArray[i] + " ");
}

}

int kol(int[] randomArray)
{
int kol = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
kol = kol + 1;
}
return kol;
}

mas(a);
Console.Write($"Количество чётных чисел в массиве: {kol(randomArray)}");