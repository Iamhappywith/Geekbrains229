/*Выведите натуральные числа от M до N*/

Console.Write("Введите первое число: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numN = int.Parse(Console.ReadLine());

Console.Write( numM + " " );

int FillNatural(int M, int N)
{
    if (M == N) return N;
    int temp = 1 + FillNatural(M, N-1);
    Console.Write(" "+ N +" ");
    return temp; 
}

FillNatural(numM, numN);