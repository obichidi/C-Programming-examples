using System;
using anotherNamespace = myNamespace.AnotherProgram;
using oneMoreNamespace = textNamespace.MorningGreet;
namespace lesson6HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            anotherNamespace.printText();
            oneMoreNamespace.Lana();
        }
    }
}
