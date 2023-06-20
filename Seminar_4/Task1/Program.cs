/* Задача 26: Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.*/


Console.WriteLine("Введите число: ");
string user_input = Console.ReadLine();

Console.WriteLine("Длина введёного числа " + user_input.Length + "символа"); 


/*Console.WriteLine("Пожалуйста введите число: ");
int user_input = int.Parse(Console.ReadLine());

int getLength(int count){
    int count = 0; 
    while(user_input != 0)
    {
        user_input = user_input / 10;
        count++;
    }
    return count;
    Console.WriteLine($"Длина введёного числа = {count}");
}*/