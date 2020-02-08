using System;

namespace Mediator.Application.Handlers
{
    public class Handler2
    {
        public string Name { get; set; } = nameof(Handler2);

        public void Notify(HandlerArgs args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            Console.WriteLine($"Greetings from {this.Name} with args {args.Value}");
        }
    }
}