﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine($"Число: {number} - палиндром.");
  }
  else Console.WriteLine($"Число: {number} - это не палиндром.");