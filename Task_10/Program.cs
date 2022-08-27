// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите любое трехзначное число: ");
int numberA = int.Parse(Console.ReadLine());
int num1 = (numberA % 100)/10;
Console.WriteLine (num1);
