namespace CFSDev.Backend.Infra.Interfaces.Exceptions.InternalException
{
    public interface IInternalException<TController, TException> : IDisposable where TException : Exception
    {
        string? ActionName { get; set; }

        TException? Exception { get; set; }

        public void Display();
    }
}
