using System;

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}

public class Program : I1, I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 method");
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 method");
    }
    public static void Main(string[] args)
    {

        Program P = new Program();
        ((I1)P).InterfaceMethod();
        ((I2)P).InterfaceMethod();
    }
}