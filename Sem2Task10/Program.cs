// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = int.Parse(Console.ReadLine()??"0");

if(number<1000&&number>99)
{
    int res = (number/10)%10;
    Console.WriteLine(res);
}