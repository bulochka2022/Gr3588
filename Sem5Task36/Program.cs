// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GenArray(123,100,999);
Print1DArr(array);
int result = SumOdd(array);
Console.WriteLine();
PrintData("Сумма элементов, стоящих на нечетных позициях: ", result);

int[] GenArray(int len, int minValue, int maxValue) //генерируем массив
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}
void PrintData(string res, int value) //выводим результат
{
    Console.WriteLine(res + value);
}

void Print1DArr(int[] arr) //выводим массив в консоль
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int SumOdd(int[] arr) //метод поиска суммы элементов, стоящих на нечетных позициях
{
    int res=0;
    int i=1;
    while(i<arr.Length)
    {
        res+=arr[i];
        i=i+2;
    }
    return res;
}