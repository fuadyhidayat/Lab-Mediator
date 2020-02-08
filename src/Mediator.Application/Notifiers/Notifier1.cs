using System;

namespace Mediator.Application.Notifiers
{
    public class Notifier1 : INotifier
    {
        public void Notify()
        {
            Console.WriteLine("Greetings from Notifier 1");
        }
    }
}