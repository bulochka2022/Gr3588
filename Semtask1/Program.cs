String? num1line = Console.ReadLine();
String? num2line = Console.ReadLine();

if(num1line!=null&&num2line!=null)
{
    int num1 = int.Parse(num1line);
    int num2 = int.Parse(num2line);

    int outResult = num1*num2;
    Console.WriteLine(outResult);
}

