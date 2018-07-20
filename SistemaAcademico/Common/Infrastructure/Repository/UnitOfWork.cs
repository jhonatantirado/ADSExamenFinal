

namespace Common.Infrastructure.Repository
{
    using Common.Infrastructure.Repository;
    using Locations.Domain.Repository;


    public class UnitOfWork  : IUnitOfWork
    {
        protected readonly PracticaExamenContext _context;

        public UnitOfWork(PracticaExamenContext dbContext)
        {
            _context = dbContext;
            Locations = new LocationsRepository(_context);

        }

        public ILocationsRepository Locations  { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
