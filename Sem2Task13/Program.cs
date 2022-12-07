// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = int.Parse(Console.ReadLine()??"0");

if(number>99)
{
    Char[] digits = number.ToString().ToCharArray();
    Console.WriteLine(digits[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}