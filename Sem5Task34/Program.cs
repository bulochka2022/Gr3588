// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GenArray(123,100,999);
Print1DArr(array);
int result = CountEven(array);
Console.WriteLine();
PrintData("Количество четных чисел в массиве: ", result);

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

int CountEven(int[] arr) //метод подсчета четных элементов в массиве
{
    int res = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i]%2==0) //если элемент делится на 2 без остатка, прибавляем к результату единицу
        res++;
    }
    return res;
}