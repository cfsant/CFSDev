using CFSDev.Backend.Infra.Interfaces.Exceptions;

namespace CFSDev.Backend.Infra.Implementations.Exceptions
{
    public class InternalException : IInternalException
    {
        public InternalException()
        {

        }

        public InternalException(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
