namespace CFSDev.Backend.Infra.Base.Interfaces
{
    public interface IBaseStateful : IBase
    {
        bool State { get; set; }
    }
}
