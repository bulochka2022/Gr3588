//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

//Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int number = numberSintezator.Next(100,1000);

//Выводим данные в консоль
Console.WriteLine(number);

//Получаем первое и последнее число по отдельности
//int firstNumber = number/100;
//int secondNumber = number%10;

//int res = (number/100)*10 + number%10;
Console.WriteLine((number/100)*10 + number%10);