// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Вводим числа:

Console.WriteLine("Введи число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи число Б: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи число С: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine($"Максимальное из трех чисел =  {max}");

Console.ReadKey();

