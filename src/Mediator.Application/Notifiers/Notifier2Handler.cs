using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Application.Notifiers
{
    public class Notifier2Handler : INotificationHandler<NotificationMessage>
    {
        public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
        {
            if (notification == null)
                throw new ArgumentNullException(nameof(notification));

            Console.WriteLine($"Greetings from Notifier 2. Message  : {notification.NotifyText} ");
            return Task.CompletedTask;
        }
    }
}