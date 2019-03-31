using GG.Dion.Domain.Entities;
using GG.Dion.Domain.Interfaces.Repositories;
using GG.Dion.Infra.Data.Context;

namespace GG.Dion.Infra.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository 
    {
        public CustomerRepository(DionProjectContext context) : base(context)
        {
        }
    }
}
