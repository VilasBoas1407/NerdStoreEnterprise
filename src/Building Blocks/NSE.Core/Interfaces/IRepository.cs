using NSE.Core.DomainObjects;

namespace NSE.Core.Interfaces
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {

    }
}
