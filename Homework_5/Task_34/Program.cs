// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте количество элементов в массиве: ");
int MassiveSize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[MassiveSize];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
    if (numbers[i] % 2 == 0)
        count++;
void FillArrayRandomNumbers(int[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("рандомный массив [ ");
    for (int q = 0; q < numbers.Length; q++)
    {
        Console.Write(numbers[q] + " ");
    }
    Console.Write("] ");
}
Console.WriteLine($" -> {count} количество четных чисел в массиве");