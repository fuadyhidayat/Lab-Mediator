using Mediator.Application.Handlers;

namespace Mediator.Application
{
    public class MyServiceWithMediator
    {
        private readonly HandlerMediator _handlerMediator;

        public MyServiceWithMediator(HandlerMediator handlerMediator)
        {
            _handlerMediator = handlerMediator;
        }

        public void DoSomething()
        {
            _handlerMediator.Notify(new HandlerArgs("HandlerMediator Notify DoSomething with MyServiceWithMediator"));
        }
    }
}