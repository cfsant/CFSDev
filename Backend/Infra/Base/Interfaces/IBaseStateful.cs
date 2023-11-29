namespace CFSDev.Backend.Infra.Interfaces.Base
{
    public interface IBaseStateful : IBase
    {
        bool State { get; set; }
    }
}
