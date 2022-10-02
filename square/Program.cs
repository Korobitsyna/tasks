// написать программу, которая на вход принимает число и выдает его квадрат.

Console.Write("Введите число:");
string numberStr = Console.ReadLine();

int number = int.Parse(numberStr); // Переменную string to int
int result = number * number;

Console.WriteLine($"{number} -> {result}");

