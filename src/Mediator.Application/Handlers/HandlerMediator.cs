namespace Mediator.Application.Handlers
{
    public class HandlerMediator
    {
        private readonly Handler1 _handler1;
        private readonly Handler2 _handler2;
        private readonly Handler3 _handler3;

        public HandlerMediator(Handler1 handler1, Handler2 handler2, Handler3 handler3)
        {
            _handler1 = handler1;
            _handler2 = handler2;
            _handler3 = handler3;
        }

        public void Notify(HandlerArgs handlerArgs)
        {
            _handler1.Notify(handlerArgs);
            _handler2.Notify(handlerArgs);
            _handler3.Notify(handlerArgs);
        }
    }
}