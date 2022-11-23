using System;
class test
{
    public static void Main(string[] args)
    {
        int pow = convert.ToInt32(Console.ReadLine());
        double a = Math.Pow(pow,2);
        double b = Math.pow(pow,3);
        Console.WriteLine(a);
        Console.WriteLine(b);

    }
}