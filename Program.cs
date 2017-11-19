using System;

namespace csharpdelegate
{
    class Program
    {
        // define a public delegate
        public delegate int Calculate(int x, int y);

        // define some method that can be invoke by delegate instance
        public int Add(int x, int y) 
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Program main = new Program();
            Calculate calc = main.Add;
            Console.WriteLine("Add result {0}", calc(10, 10));
            
            calc = main.Multiply;
            Console.WriteLine("Multiple result {0}", calc(10, 10));
        }
    }
}
