﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Создаем массив. Введите номер строки");
int TableStrings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int TableColumns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[10, 10];
FillArrayRandomNumbers(numbers);

if (TableStrings > numbers.GetLength(0) || TableColumns > numbers.GetLength(1))
{
    Console.WriteLine("К сожалению, такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {TableStrings} строки и {TableColumns} столбца равно {numbers[TableStrings - 1, TableColumns - 1]}");
}
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}