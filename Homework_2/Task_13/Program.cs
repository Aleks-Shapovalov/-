// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое трехзначное число: ");
int numberA = int.Parse(Console.ReadLine());

if (numberA < 100)
{
    Console.WriteLine($"третьей цифры нет");
}
if (numberA > 1000)
{
    Console.WriteLine(numberA.ToString()[2]);
}
else
{
    int num1 = (numberA % 100)%10;
    Console.WriteLine(num1);
}