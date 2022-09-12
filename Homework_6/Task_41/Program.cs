// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите числа для подсчета: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
int[] StringToNum(string input)
{
    int count = 1;
    for (int j = 0; j < input.Length; j++)
    {
        if (input[j] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int[count];
    int index = 0;

    for (int q = 0; q < input.Length; q++)
    {
        string temp = "";

        while (input[q] != ',')
        {
            if (q != input.Length - 1)
            {
                temp += input[q].ToString();
                q++;
            }
            else
            {
                temp += input[q].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}
void PrintArray(int[] array)
{
    for (int g = 0; g < array.Length; g++)
    {
        Console.Write(array[g] + " ");
    }
}
Console.WriteLine($"-> {sum} - количество значений больше 0");