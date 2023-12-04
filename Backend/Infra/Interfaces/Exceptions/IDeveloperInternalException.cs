namespace CFSDev.Backend.Infra.Interfaces.Exceptions
{
    public interface IDeveloperInternalException : IInternalException
    {
        Exception? InnerException { get; set; }
        string StackTrace { get; set; }
    }
}
