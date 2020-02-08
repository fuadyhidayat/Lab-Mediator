using System.Collections.Generic;

namespace Mediator.Application.Notifiers
{
    public class NotifierMediatorService : INotifierMediatorService
    {
        private readonly IEnumerable<INotifier> _notifiers;

        public NotifierMediatorService(IEnumerable<INotifier> notifiers)
        {
            _notifiers = notifiers;
        }

        public void Notify()
        {
            foreach (INotifier notifier in _notifiers)
            {
                notifier.Notify();
            }
        }
    }
}