using Mediator.Application;
using Mediator.Application.Handlers;
using System;

namespace Mediator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"args.Length {args.Length}");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"args[{i}]: {args[i]}");
            }

            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();
            Handler3 handler3 = new Handler3();

            MyService myService = new MyService(handler1, handler2, handler3);

            myService.DoSomething();
        }
    }
}