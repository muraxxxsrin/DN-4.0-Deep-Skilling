using System;
using BuilderPatternExample;

class Program
{
    static void Main(string[] args)
    {
        var i5Computer = new Computer.Builder().buildCPU("i5").buildRAM("8GB").buildStorage("500GB").Build();
        Console.WriteLine("\ni5Computer:\n" + i5Computer.String());
        
        var i7Computer = new Computer.Builder().buildCPU("i7").buildRAM("16GB").buildStorage("1TB").Build();
        Console.WriteLine("\ni7Computer:\n" + i7Computer.String());
    }
}