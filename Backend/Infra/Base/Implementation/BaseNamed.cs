using CFSDev.Backend.Infra.Interfaces.Base;

namespace CFSDev.Backend.Infra.Implementations.Base
{
    public class BaseNamed : Base, IBase, IBaseNamed
    {
        public string? Name { get; set; }
    }
}
