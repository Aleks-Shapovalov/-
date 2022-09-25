// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Необходимо ввести значение M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Необходимо ввести значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {numberM}; N = {numberN}. -> ");
if (numberM < numberN)
    for (int i = numberM; i <= numberN; i++)
        Console.Write($" {i}");
else
        Console.Write($"Значение M должно быть больше значения N");