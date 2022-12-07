// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int number = int.Parse(Console.ReadLine()??"0");

if(number>0&&number<8)
{
    if(number>5)
    {
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("рабочий день");
    }
}
