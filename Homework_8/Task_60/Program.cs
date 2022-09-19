// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int size1 = InputInt("Формируем трехмерный массив. Введите первый размер: ");
int size2 = InputInt("Введите второй размер: ");
int size3 = InputInt("Введите третий размер: ");
int countNums = 89;
if (size1 * size2 * size3 > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNums = Create3DMassive(size1, size2, size3);
for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int q = 0; q < resultNums.GetLength(2); q++)
        {
            Console.WriteLine($"[{i},{j},{q}] - {resultNums[i, j, q]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int q = 0; q < array.GetLength(2); q++)
            {
                array[i, j, q] = values[valueIndex++];
            }
        }
    }
    return array;
}
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

if (size1 * size2 * size3 > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}