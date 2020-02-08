using Mediator.Application;
using Mediator.Application.Handlers;
using System;

namespace Mediator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteArguments(args);

            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();
            Handler3 handler3 = new Handler3();

            MyServiceNormal myServiceNormal = new MyServiceNormal(handler1, handler2, handler3);
            myServiceNormal.DoSomething();

            WriteSeparator();

            HandlerMediator handlerMediator = new HandlerMediator(handler1, handler2, handler3);
            MyServiceWithMediator myServiceWithMediator = new MyServiceWithMediator(handlerMediator);
            myServiceWithMediator.DoSomething();
        }

        private static void WriteArguments(string[] args)
        {
            Console.WriteLine($"args.Length {args.Length}");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"args[{i}]: {args[i]}");
            }
        }

        static void WriteSeparator()
        {
            string Separator = new string('=', 100);
            Console.WriteLine(Separator);
        }
    }
}