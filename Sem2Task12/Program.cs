//Напишите программу, которая будет на входе принимать 2 числа и выводить является ли второе число кратным первому. Если второе число не кратно первому, то программа выводит остаток от деления.

int number1 = int.Parse(Console.ReadLine()??"0");

//Console.WriteLine(number1);

int number2 = int.Parse(Console.ReadLine()??"0");

int result = number2%number1;

if (result == 0)
{
    Console.WriteLine("Второе число делится на первое без остатка");
}
else
{
    Console.WriteLine("Второе число не кратно первому. Остаток от деления " + result);
}