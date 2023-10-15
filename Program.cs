// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//int NumberSearch (int num)
//{
//    if (num >= 100)
//    {
//    int newnum = (num % 100) / 10;
//    return newnum;
//    } else {
//        Console.WriteLine ("Введите, пожалуйста, трехзначное число"); return 0; }
//}
//Console.WriteLine ("Введите трехзначное число: ");
//int num = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine (NumberSearch(num));

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//int NumberSearch (int num)
//{
//    int newnum = 0;
//    if ((num >= 100) && (num < 1000)) newnum = num % 10;
//    else if ((num >= 1000) && (num < 10000)) newnum = (num % 100)/10;
//    else if ((num >= 10000) && (num < 100000)) newnum = (num % 1000)/100;
//    else if (num < 100) Console.WriteLine ("Третьей цифры нет");
//    else Console.WriteLine ("Введите, пожалуйста, число в диапозоне от 100 до 100000");  
//    return newnum;
//}
//Console.WriteLine ("Введите число: ");
//int num = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine (NumberSearch(num));

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

void DayOfTheWeek (int num)
{
    if ((num == 6) || (num == 7))
    Console.WriteLine ($"{num} -> да"); 
    else Console.WriteLine ($"{num} -> нет"); 
}
Console.WriteLine ("Введите число, я проверю, являеется ли оно выходным: ");
int num = Convert.ToInt32 (Console.ReadLine());
DayOfTheWeek(num);