/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число:");
string firstnumber = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string secondnumber = Console.ReadLine();

int firstnum = int.Parse(firstnumber); 
int secondnum = int.Parse(secondnumber); 

if(firstnum > secondnum)
{
    Console.WriteLine($"{firstnumber}, {secondnumber} -> max = {firstnumber}");
}
else
{
    Console.WriteLine($"{firstnumber}, {secondnumber} -> max = {secondnumber}");
}