using System.Collections.Generic;
using Happy.Models;

namespace Happy.Database
{
  public class MockOrphanageRepository : IOrphanageRepository
  {
    public void CreateOrphanage(Orphanage orphanage)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteOrphanage(Orphanage orphanage)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Orphanage> GetAllOrphanages()
    {
      var orphanages = new List<Orphanage> 
      {
        new Orphanage 
        {
          Id = 1,
          Name = "Casa betania",
          Latitude = -21.7937801,
          Longitude = -48.1814702,
          About = "Casa de acolhimento Betania",
          Instructions = "Venha nos visitar",
          Open_on_weekends = false,
          Opening_hours = "Das 8h às 16h"
        },
        new Orphanage 
        {
          Id = 2,
          Name = "Minha casa",
          Latitude = -21.7937801,
          Longitude = -48.1814702,
          About = "Esta é minha casa",
          Instructions = "Chama no role",
          Open_on_weekends = true,
          Opening_hours = "Das 21h às 02h"
        }
      };

      return orphanages;
    }

    public Orphanage GetOrphanageById(int id)
    {
      return new Orphanage
      {
        Id = 1,
        Name = "Casa betania",
        Latitude = -21.7937801,
        Longitude = -48.1814702,
        About = "Casa de acolhimento Betania",
        Instructions = "Venha nos visitar",
        Open_on_weekends = true,
        Opening_hours = "Das 8h às 16h"
      };
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdateOrphanage(Orphanage orphanage)
    {
      throw new System.NotImplementedException();
    }
  }
}