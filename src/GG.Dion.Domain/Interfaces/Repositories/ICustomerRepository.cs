using GG.Dion.Domain.Entities;

namespace GG.Dion.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository : IRepositoryRead<Customer>, IRepositoryWrite<Customer>
    {
    }
}
