// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = InputInt("Необходимо ввести значение M:");
int numberN = InputInt("Необходимо ввести значение N:");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int numberM, int numberN)
{
    if (numberM == numberN)
        return numberN;
    return numberN + CountNaturalSum(numberM, numberN - 1);
}
Console.WriteLine($" M = {numberM}; N =  {numberN} -> {CountNaturalSum(numberM, numberN)} - сумма элементов");
