using System.Collections.Generic;
using System.Linq;
using Happy.Models;

namespace Happy.Database
{
  public class SqlOrphanageRepository : IOrphanageRepository
  {
    private readonly HappyDbContext _context;

    public SqlOrphanageRepository(HappyDbContext context)
    {
      _context = context;
    }

    public IEnumerable<Orphanage> GetAllOrphanages()
    {
      return _context.Orphanages.ToList();
    }

    public Orphanage GetOrphanageById(int id)
    {
      return _context.Orphanages.FirstOrDefault(o => o.Id == id);
    }
  }
}