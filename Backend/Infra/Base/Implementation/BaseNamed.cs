using CFSDev.Backend.Infra.Base.Interfaces;

namespace CFSDev.Backend.Infra.Implementations.Base
{
    public class BaseNamed : Base, IBase, IBaseNamed
    {
        public string? Name { get; set; }
    }
}
