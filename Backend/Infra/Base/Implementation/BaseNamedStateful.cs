using CFSDev.Backend.Infra.Base.Interfaces;

namespace CFSDev.Backend.Infra.Implementations.Base
{
    public class BaseNamedStateful : Base, IBaseNamedStateful
    {
        public string? Name { get; set; }
        public bool State { get; set; }
    }
}
