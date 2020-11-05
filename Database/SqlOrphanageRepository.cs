using System;
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

    public void CreateOrphanage(Orphanage orphanage)
    {
      if (orphanage == null) 
      {
        throw new ArgumentException(nameof(orphanage));
      }

      _context.Orphanages.Add(orphanage);
    }

    public void UpdateOrphanage(Orphanage orphanage)
    {
      // nothing yet
    }

    public void DeleteOrphanage(Orphanage orphanage)
    {
      if (orphanage == null) 
      {
        throw new ArgumentException(nameof(orphanage));
      }

      _context.Orphanages.Remove(orphanage);      
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }
  }
}