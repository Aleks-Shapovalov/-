// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите любую цифру, до которой будем считать: ");
int max = int.Parse(Console.ReadLine());
string result = "";
for (int i = 1; i <= max; i++)
{
double res = Math.Pow(i, 3);
result = result + res + " | ";
}
Console.WriteLine(result);