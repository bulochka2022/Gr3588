// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int SumMNRec(int M, int N)
{
    if (M >= N) return N;
      
    return M + SumMNRec(M + 1, N);
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int resultLine = number1<number2? SumMNRec(number1, number2):SumMNRec(number2, number1);
PrintResult(resultLine);
