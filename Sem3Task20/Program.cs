// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int X1 = ReadData("Введите координату Х1: ");
int X2 = ReadData("Введите координату Х2: ");
int Y1 = ReadData("Введите координату Y1: ");
int Y2 = ReadData("Введите координату Y2: ");

double result = DistanceBetweenPoints(X1, X2, Y1, Y2);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//Метод находит расстояние между точками на плоскости
double DistanceBetweenPoints(double x, double y, double x0, double y0)
{
    double distance = Math.Sqrt((x0-x)*(x0-x)+(y0-y)*(y0-y));
    return distance;
}

//Метод выводит данные пользователя
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

PrintData("Расстояние между точками: ", result);