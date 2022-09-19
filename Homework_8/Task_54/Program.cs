// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Создаем массив. Введите количество строк");
int MassiveStrings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int MassiveColumns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[MassiveStrings, MassiveColumns];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Рандомно сгенерированный массив");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int q = 0; q < numbers.GetLength(1) - 1; q++)
        {
            if (numbers[i, q] < numbers[i, q + 1])
            {
                int temp = 0;
                temp = numbers[i, q];
                numbers[i, q] = numbers[i, q + 1];
                numbers[i, q + 1] = temp;
            }
        }
    }
}
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
Console.WriteLine();
Console.WriteLine("Упорядоченный массив");
PrintArray(numbers);