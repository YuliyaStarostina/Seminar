// Напишите программу, которая на вход принимает число и выдает, явлется ли число четным (делится ли оно на 2 без остатка)

Console.WriteLine ("Введите число:  ");
int a = Convert.ToInt32 (Console.ReadLine()!);

if ( a % 2 == 0)
{
    Console.WriteLine ($"Число {a} является четным");
}
else
{
    Console.WriteLine ($"Число {a} не является четным");
}

