using GG.Dion.Infra.Data.UoW;

namespace GG.Dion.Application.Services
{
    public abstract class BaseService
    {
        private readonly IUnitOfWork _uow;

        protected BaseService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        protected void Commit()
        {
            _uow.Commit();
        }
    }
}
