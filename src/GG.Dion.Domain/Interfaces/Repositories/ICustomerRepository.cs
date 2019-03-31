using GG.Dion.Domain.Entities;

namespace GG.Dion.Domain.Interfaces.Repositories
{
    interface ICustomerRepository : IRepositoryRead<Customer>, IRepositoryWrite<Customer>
    {
    }
}
