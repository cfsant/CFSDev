namespace CFSDev.Backend.Infra.Interfaces.Exceptions.Internal
{
    public interface IBaseException<TController, TException> : IDisposable where TException : Exception
    {
        string? ActionName { get; set; }

        TException? Exception { get; set; }

        public void Display();
    }
}
