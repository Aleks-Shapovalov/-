﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numA, int numB)
{
int result = 1;
for(int i=1; i <= numB; i++)
{
    result = result * numA;
}
    return result;
}
int exponentiation = Exponentiation(numA, numB);
Console.WriteLine($"{numA} в степени {numB} равняется {exponentiation}");
