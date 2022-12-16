// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int Pow(int a, int b)
{
    int res = 1;
    for(int i=1;i<=b;i++)
    {
        res = a*res;
    }
    return res;
}

int a = ReadData("Введите число А: ");
int b = ReadData("Введите число B: ");
int length = Pow(a, b);
PrintData("A в степени B равно: " + length);