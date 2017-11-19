using System;

namespace csharpdelegate
{
    class Program
    {
        // define a public delegate
        public delegate int Calculate(int x, int y);
        //public delegate void Del();
        // using build-in delegate type instead
        public Action del { get; set; }

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

        // apply pub-sub pattern, raise event to delegate handler
        public void Raise()
        {
            if (del != null)
            {
                del();
            } else 
            {
                Console.WriteLine("del is null");
            }
        }

        public void Multicast()
        {
            //del = MethodOne;
            //del += MethodTwo;
            // Using lambda expression for convenient
            del = () => Console.WriteLine("MethodOne");
            del += () => Console.WriteLine("MethodTwo");
            //Console.WriteLine("Get invocation list {0}", del.GetInvocationList().GetLength(0));
            //del();
        }

        static void Main(string[] args)
        {
            Program main = new Program();
            main.Raise();
        }
    }
}
