using System.Collections.Generic;
using Happy.Models;

namespace Happy.Database
{
  public interface IOrphanageRepository
  {
    IEnumerable<Orphanage> GetAllOrphanages();
    Orphanage GetOrphanageById(int id);
  }
}