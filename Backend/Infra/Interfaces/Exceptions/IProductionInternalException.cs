using CFSDev.Backend.Infra.Interfaces.Exceptions;

namespace Backend.Infra.Interfaces.Exceptions
{
    public interface IProductionInternalException : IInternalException
    {
        string Detail { get; set; }
    }
}
