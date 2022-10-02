/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число:");
string firstnumber = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string secondnumber = Console.ReadLine();
Console.WriteLine("Введите третье число:");
string thirdnumber = Console.ReadLine();

int firstnum = int.Parse(firstnumber);
int secondnum = int.Parse(secondnumber);
int thirdnum = int.Parse(thirdnumber);


if (firstnum > secondnum && firstnum > thirdnum)
{
    Console.WriteLine($"{firstnum}, {secondnum}, {thirdnum} -> max = {firstnum}");
}
else if (secondnum > firstnum && secondnum > thirdnum)
{
    Console.WriteLine($"{firstnum}, {secondnum}, {thirdnum} -> max = {secondnum}");
}
else
{
    Console.WriteLine($"{firstnum}, {secondnum}, {thirdnum} -> max = {thirdnum}");
}
