﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число для проверки: ");
int numberA = int.Parse (Console.ReadLine());

for (int x = 1; x < numberA; x++)       
if (x%2==0)            
Console.WriteLine(x);