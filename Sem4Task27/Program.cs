// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int SumDigit(int num)
{
    int res = 0;
    while(num>0)
    {
        res += num%10;
        num = num/10;
    }
    return res;
}

int num = ReadData("Введите число: ");
int sum = SumDigit(num);
PrintData("Сумма цифр в числе равна: " + sum);