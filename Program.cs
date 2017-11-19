using System;

namespace csharpdelegate
{
    class Program
    {
        // define a public delegate
        public delegate int Calculate(int x, int y);
        public delegate void Del();

        // define some method that can be invoke by delegate instance
        public int Add(int x, int y) 
        {
            Console.WriteLine("Add");
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            Console.WriteLine("Multiple");
            return x * y;
        }

        public void MethodOne() 
        {
            Console.WriteLine("MethodOne");
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;
            Console.WriteLine("Get invocation list {0}", d.GetInvocationList().GetLength(0));
            d();
        }

        static void Main(string[] args)
        {
            Program main = new Program();
            main.Multicast();
        }
    }
}
