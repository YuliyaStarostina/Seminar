// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число: ");
string i = Console.ReadLine();

if (int.Parse (i) > 99)
{ 
    Console.WriteLine(i[2]); 
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
