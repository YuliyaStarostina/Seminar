// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N;

Console.WriteLine ("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine ()!);
int j = 2;

while (j <= n)
{
    Console.Write ($"{j} ");
    j +=2;
}