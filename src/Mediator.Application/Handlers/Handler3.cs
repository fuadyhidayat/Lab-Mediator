using System;

namespace Mediator.Application.Handlers
{
    public class Handler3
    {
        public string Name { get; set; } = nameof(Handler3);

        public void Notify(HandlerArgs args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            Console.WriteLine($"Greetings from {this.Name} with args {args.Value}");
        }
    }
}