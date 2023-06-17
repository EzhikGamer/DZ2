// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Номер дня недели");
int D=Convert.ToInt32(Console.ReadLine());
switch(D)
{
    case 1:
    System.Console.WriteLine("Понедельник - Иди работай");
    break;

    case 2:
    System.Console.WriteLine("Вторник - Иди работай");
    break;

    case 3:
    System.Console.WriteLine("Среда - Иди работай");
    break;

    case 4:
    System.Console.WriteLine("Четверг - Иди работай");
    break;

    case 5:
    System.Console.WriteLine("Пятница - Иди работай");
    break;

    case 6:
    System.Console.WriteLine("Суббота - Выходной!");
    break;

    case 7:
    System.Console.WriteLine("Воскресенье - Выходной");
    break;
}
if(D>7)
{
    System.Console.WriteLine("Такого дня недели нету");
}
