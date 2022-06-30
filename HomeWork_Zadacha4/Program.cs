//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

internal class Program
{
    private static void Main(string[] args)
    {
        int elementsCount = 3;

        int[] Array = new int[elementsCount];

        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write($"Введите число №{i}: ");

            Array[i] = int.Parse(Console.ReadLine()!);
        }

    int j = 0;
    int max = 0;

    while (j < elementsCount)
    {
        if (max < Array[j])
        {
            max = Array[j];
        }
        else {}
    j ++;
    }
    Console.WriteLine ($"Максимальное число: " + max);

    }
}