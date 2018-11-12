using System;

namespace DroneDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new MessageProcessor();
            Console.WriteLine(processor.GetMessage());
        }
    }
}
