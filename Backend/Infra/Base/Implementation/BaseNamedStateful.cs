using CFSDev.Backend.Infra.Interfaces.Base;

namespace CFSDev.Backend.Infra.Implementations.Base
{
    public class BaseNamedStateful : Base, IBaseNamedStateful
    {
        public string? Name { get; set; }
        public bool State { get; set; }
    }
}
