using System;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackString();

            Console.ReadLine();

        }
        

        private static void StackDoubles() {
            var stack = new SimpleStack<double>();

            stack.Push(2.4);
            stack.Push(1.3);
            stack.Push(2.9);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");

                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");

        }

        private static void StackString()
        {
            var stack = new SimpleStack<string>();
            stack.Push("Wired Brain Coffee");   
            stack.Push("Pluralsight");

            while(stack.Count > 0 )
            {
                string item = (string)stack.Pop();
                Console.WriteLine($"Item: {item}");
            }


        }
    }
}
