using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using Happy.Models;
using Happy.Database;

namespace Happy.Controllers
{
  [Route("api/orphanages")]
  [ApiController]
  public class OrphanagesController : ControllerBase
  {
    private readonly IOrphanageRepository _repository;

    public OrphanagesController(IOrphanageRepository repository)
    { 
      _repository = repository;
    }

    // GET api/orphanages
    [HttpGet]
    public ActionResult <IEnumerable<Orphanage>> GetAllOrphanages()
    {
      var orphanageItems = _repository.GetAllOrphanages();

      return Ok(orphanageItems);
    }

    // GET api/orphanages/{id}
    [HttpGet("{id}")]
    public ActionResult <Orphanage> GetOrphanageById(int id)
    {
      var orphanageItem = _repository.GetOrphanageById(id);

      return Ok(orphanageItem);
    }
  }
}