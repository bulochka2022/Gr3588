//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Считываем данные с консоли
string? num1line = Console.ReadLine();
string? num2line = Console.ReadLine();
string? num3line = Console.ReadLine();

//Проверяем чтобы данные были не пустыми
if(num1line!=null&&num2line!=null&&num3line!=null)
{
    //Парсим введенные числа
    int num1 = int.Parse(num1line);
    int num2 = int.Parse(num2line);
    int num3 = int.Parse(num3line);

    //Выводим данные в консоль
    Console.WriteLine(Math.Max(num1, Math.Max(num2, num3)));
}