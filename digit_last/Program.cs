/* Напишите программу, которая принимает на вход трехзначное число
и на выходе показывает последнюю цифру этого числа.
456 -> 6 */

Console.WriteLine("Введите трехзначное число ");
string number = Console.ReadLine();
int num = int.Parse(number); 

if (num < 1000 && num > 99)
{
    Console.WriteLine(num%10);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}