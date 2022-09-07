// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте количество элементов в массиве: ");
int MassiveSize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[MassiveSize];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i += 2)
    sum = sum + numbers[i];

void FillArrayRandomNumbers(int[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(1, 10);
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
Console.WriteLine($" -> {sum} сумма элементов, стоящих на нечётных позициях");