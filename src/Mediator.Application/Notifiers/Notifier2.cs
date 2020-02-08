using System;

namespace Mediator.Application.Notifiers
{
    public class Notifier2 : INotifier
    {
        public void Notify()
        {
            Console.WriteLine("Greetings from Notifier 2");
        }
    }
}