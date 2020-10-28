using System.Collections.Generic;
using Happy.Models;

namespace Happy.Database
{
  public interface IOrphanageRepository
  {
    bool SaveChanges();

    IEnumerable<Orphanage> GetAllOrphanages();
    Orphanage GetOrphanageById(int id);
    void CreateOrphanage(Orphanage orphanage);
  }
}