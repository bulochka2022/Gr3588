// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Метод читает данные от пользователя

int ReadData(string line)
{
Console.Write(line);
int numberP = int.Parse(Console.ReadLine() ?? "0");
return numberP;
}

// Метод вывода данных

void PrintResult( string line)
{
Console.WriteLine(line);
}

int VariantSumSimple(int numA)
{
    int sumOfnumbers =0;
    for(int i=1; i<=numA; i++)
    {
        sumOfnumbers+=i;
    }
    return sumOfnumbers;
}

int numberA = ReadData("Введите число А: ");

int res1 = VariantSumSimple(numberA);

PrintResult("Сумма чисел от 1 до А равна(простой метод):" + res1);