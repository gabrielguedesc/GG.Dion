using GG.Dion.Infra.Data.Context;

namespace GG.Dion.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DionProjectContext _context;

        public UnitOfWork(DionProjectContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
