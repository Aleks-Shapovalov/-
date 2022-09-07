// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте количество элементов в массиве: ");
int MassiveSize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[MassiveSize];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
void FillArrayRandomNumbers(int[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = Convert.ToInt32(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int q = 0; q < numbers.Length; q++)
    {
        Console.Write(numbers[q] + " ");
    }
    Console.Write("]");
}
Console.WriteLine($"-> {max - min} - разница между максимальным и минимальным значением");