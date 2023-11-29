namespace CFSDev.Backend.Infra.Interfaces.Base
{
    public interface IBaseNamed : IBase
    {
        string? Name { get; set; }
    }
}
