// Напишите программу, которая на вход будет принимать 2 числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно первому, то программа выводит остаток от деления.

System.Console.WriteLine("Введите первое число: ");
int numberOne = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int numberTwo = int.Parse(System.Console.ReadLine());

if (numberOne % numberTwo == 0)
{
    System.Console.WriteLine($"Число {numberOne} кратно числу {numberTwo}");
}
else
{
    System.Console.WriteLine(
        $"Число {numberOne} не кратно числу {numberTwo}," +
         $"остаток от деления {numberOne % numberTwo}");
}

