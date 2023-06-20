/*Напишите программу, которая принимает на вход число N и 
выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

int result = 1;

Console.WriteLine("Введите число: ");
int input_number = int.Parse(Console.ReadLine());

for (int i = 1; i <= input_number; i++)
{
    result *= i;
    Console.WriteLine($"Промежуточный результат {result}"); 
}

    Console.WriteLine($"Производная всех чисел от 1 до {input_number} равняется {result}");

/*
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int getFactorial(int number){

    int result = 1;
    for(int i = 1; i <= number; i ++)
    {
        result *= i;
    }
        return result;

}
 
Console.WriteLine(getFactorial(number));*/