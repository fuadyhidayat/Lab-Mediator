namespace Mediator.Application.Handlers
{
    public class HandlerArgs
    {
        public string Value { get; set; }

        public HandlerArgs() : this("Handler Args Default Value")
        {
        }

        public HandlerArgs(string value)
        {
            this.Value = value;
        }
    }
}