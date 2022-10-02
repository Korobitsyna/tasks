/* Напишите программу, которая на вход принимает число N, а на выходе показывает 
все целые числа от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" */

Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int num = int.Parse(number); 

for (int i = - num; i <= num; i++)
{
    Console.WriteLine($"{i}");
}