using CFSDev.Backend.Infra.Interfaces.Exceptions.InternalException;

namespace CFSDev.Backend.Infra.Implementations.Exceptions.Internal
{
    public class InternalException<TController, TException> : IDisposable where TException : Exception, IInternalException<TController, TException>
    {
        public string? ActionName { get; set; }

        public TException? Exception { get; set; }

        public InternalException(string actionName, TException exception)
        {
            this.ActionName = actionName;
            this.Exception = exception;
        }

        public void Display()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{DateTime.Now}] The application threw an exception:");
            Console.ResetColor();
            Console.Write("An exception was thrown in the controller: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"'{typeof(TController).Name}';");
            Console.Write("StackTrace:");
            Console.ResetColor();
            Console.WriteLine($"'{Exception?.StackTrace}'");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Message: ");
            Console.ResetColor();
            Console.WriteLine($"{Exception?.Message}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("InnerException: ");
            Console.ResetColor();
            Console.WriteLine($"{Exception?.InnerException?.Message}");
            Console.WriteLine("\n\n");
        }

        public void Dispose()
        {
            this.ActionName = null;
            this.Exception = null;
        }
    }
}
