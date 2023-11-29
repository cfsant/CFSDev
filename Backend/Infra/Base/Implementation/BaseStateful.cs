using CFSDev.Backend.Infra.Interfaces.Base;

namespace CFSDev.Backend.Infra.Implementations.Base
{
    public class BaseStateful : Base, IBase, IBaseStateful
    {
        public bool State { get; set; }
    }
}
