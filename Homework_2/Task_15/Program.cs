// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите любую цифру, обозначающую день недели: ");
int numberA = int.Parse(Console.ReadLine());

if (numberA == 1)
Console.WriteLine("Понедельник. Это будний день");

if (numberA == 2)
Console.WriteLine("Вторник. Это будний день");

if (numberA == 3)
Console.WriteLine("Среда. Это будний день");

if (numberA == 4)
Console.WriteLine("Четверг. Это будний день");

if (numberA == 5)
Console.WriteLine("Пятница. Это будний день, но уже почти выходные");

if (numberA == 6)
Console.WriteLine("Суббота. УРА! Это выходной");

if (numberA == 7)
Console.WriteLine("Суббота. УРА! Это выходной");

else
{
    Console.WriteLine("ты шо? в неделе только 7 дней");
}