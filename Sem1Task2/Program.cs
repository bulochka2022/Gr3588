//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Считываем данные с консоли
string? num1line = Console.ReadLine();
string? num2line = Console.ReadLine();

//Проверяем чтобы данные были не пустыми
if(num1line!=null&&num2line!=null)
{
    //Парсим введенные числа
    int num1 = int.Parse(num1line);
    int num2 = int.Parse(num2line);

    if(num1 > num2)
    {
        Console.WriteLine("max=" + num1line); //Выводим данные в консоль
    }
    else
    {
        Console.WriteLine("max=" + num2line); //Выводим данные в консоль
    }
}