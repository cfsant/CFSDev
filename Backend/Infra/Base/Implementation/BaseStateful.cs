using CFSDev.Backend.Infra.Base.Interfaces;

namespace CFSDev.Backend.Infra.Implementations.Base
{
    public class BaseStateful : Base, IBase, IBaseStateful
    {
        public bool State { get; set; }
    }
}
