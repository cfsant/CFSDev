namespace CFSDev.Backend.Infra.Base.Interfaces
{
    public interface IBaseNamed : IBase
    {
        string? Name { get; set; }
    }
}
