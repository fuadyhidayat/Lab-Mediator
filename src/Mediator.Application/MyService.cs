using Mediator.Application.Handlers;

namespace Mediator.Application
{
    public class MyService
    {
        private readonly Handler1 _handler1;
        private readonly Handler2 _handler2;
        private readonly Handler3 _handler3;

        public MyService(Handler1 handler1, Handler2 handler2, Handler3 handler3)
        {
            _handler1 = handler1;
            _handler2 = handler2;
            _handler3 = handler3;
        }

        public void DoSomething()
        {
            _handler1.Notify(new HandlerArgs());
            _handler2.Notify(new HandlerArgs());
            _handler3.Notify(new HandlerArgs());
        }
    }
}