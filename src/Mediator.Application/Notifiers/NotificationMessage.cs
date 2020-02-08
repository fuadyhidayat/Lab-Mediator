using MediatR;

namespace Mediator.Application.Notifiers
{
    public class NotificationMessage : INotification
    {
        public string NotifyText { get; set; }
    }
}