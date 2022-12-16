// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int ReadData(string msg)
{
Console.WriteLine(msg);
return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
Console.WriteLine(res);
}

long CalcFactor(int num)
{
    long count = 1;
    for(int i=1;i<=num;i++)
    {
        count *= i;
    }
    return count;
}

int number = ReadData("Введите число А:");
long length = CalcFactor(number);
PrintData("Факториал равно: " + length);
