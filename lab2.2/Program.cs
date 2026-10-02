using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

//try
//{
//    Console.Write("введи x: ");
//        double x = double.Parse(Console.ReadLine());
//    Console.Write("введи y: ");
//        double y = double.Parse(Console.ReadLine());
//    double max, min;
//    if (x > y)
//    {
//        max = x;
//        min = y;
//    }
//    else
//    {
//        max = x;
//        min = y;
//    }
//    Console.WriteLine($"max ={max}, min={min},");
//}


//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}



//try
//{
//    Console.Write("введи a: ");
//    double a = double.Parse(Console.ReadLine()); ;
//    Console.Write("введи b: ");
//    double b = double.Parse(Console.ReadLine()); ;
//    Console.Write("введи c: ");
//    double c = double.Parse(Console.ReadLine()); ;
//    if ((a < b) && (b < c)) Console.WriteLine($"{a}<{b}<{c}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.WriteLine("введи m:");
//    int m = int.Parse(Console.ReadLine());
//    int a = m / 100;
//    int b = m / 10 % 10;
//    int c = m % 10;
//    if ((a == 4 || b == 4 || c == 4) || (a == 7 || b == 7 || c == 7))
//        Console.WriteLine("да");
//    else Console.WriteLine("нет");

//    if ((a == 3 || b == 3 || c == 3)|| (a == 6 || b == 6 || c == 6)||
//        (a == 9 || b == 9 || c == 9)) Console.WriteLine("да");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//вариант 30 - базовая
//try
//{
//    Console.WriteLine("введи n:");
//    int n = int.Parse(Console.ReadLine());
//    if (n%2==0 || n%10==7) Console.WriteLine("да");
//    else Console.WriteLine("нет"); ;
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}



//вариант 30 - средний
//try
//{
//    Console.WriteLine("введи a:");
//        int a = int.Parse(Console.ReadLine());
//    Console.WriteLine("введи b:");
//        int b = int.Parse(Console.ReadLine());
//    Console.WriteLine("введи c:");
//        int c = int.Parse(Console.ReadLine());
//    int max = a;

//    if ((b > a) && (a > c)) max = b;
//    else if ((c > a) && (c > b)) max = c;
//    Console.WriteLine($"max={max}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


try
{
    Console.Write("Введи x: ");
        double x = double.Parse(Console.ReadLine()); ;
    Console.Write("Введи y: ");
        double y = double.Parse(Console.ReadLine()); ;
    if (y >= 0 && y <= 2 - x * x)
    {
        Console.WriteLine($"x = {x}, y = {y}");
    }
    else
    {
        Console.WriteLine("не лежит в области");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}