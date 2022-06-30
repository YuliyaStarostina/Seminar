// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот 
//день выходным.

Console.WriteLine ("Введите номер дня недели: ");
int i = Convert.ToInt32(Console.ReadLine ()!);

if (i > 0 && i <= 5)
{
    System.Console.WriteLine("Будний день");
}
if (i > 5 && i < 8)
{
    System.Console.WriteLine("Выходной день");
}
else 
{
    if (i <= 0 || i > 7)
    {
        System.Console.WriteLine("Ошибка, введите повторно номер дня недели");
    }
    
}