// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//Считываем данные с консоли
string? numLine = Console.ReadLine();

//Проверяем чтобы данные были не пустыми
if(numLine!=null)
{
    //Парсим введенное число
    int N = int.Parse(numLine);
    //Вводим новую переменную
    int C = 2;
    //Выходное значение
    string res = string.Empty;
   
    while (C<=N)
    {
        res = res + C + ", ";
        C = C + 2; 
    }

//Выводим данные в консоль
Console.WriteLine(res);
}