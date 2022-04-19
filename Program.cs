using System;

namespace Zoo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Cat Tom = new Cat();
            Cat Jerry = new Cat(4,"Джерри");

            Tom.PrintInfo();
            Tom.Meow();
            Jerry.PrintInfo();
            Jerry.Meow();

        }
    }
}