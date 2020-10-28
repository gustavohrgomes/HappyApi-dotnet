using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using Happy.Models;
using Happy.Database;
using Happy.Dtos;

using AutoMapper;

namespace Happy.Controllers
{
  [Route("api/orphanages")]
  [ApiController]
  public class OrphanagesController : ControllerBase
  {
    private readonly IOrphanageRepository _repository;
    private readonly IMapper _mapper;

    public OrphanagesController(IOrphanageRepository repository, IMapper mapper)
    { 
      _repository = repository;
      _mapper = mapper;
    }

    // GET api/orphanages
    [HttpGet]
    public ActionResult <IEnumerable<OrphanageReadDto>> GetAllOrphanages()
    {
      var orphanageItems = _repository.GetAllOrphanages();

      return Ok(_mapper.Map<IEnumerable<OrphanageReadDto>>(orphanageItems));
    }

    // GET api/orphanages/{id}
    [HttpGet("{id}")]
    public ActionResult <OrphanageReadDto> GetOrphanageById(int id)
    {
      var orphanageItem = _repository.GetOrphanageById(id);

      if (orphanageItem != null)
        return Ok(_mapper.Map<OrphanageReadDto>(orphanageItem));

      return NotFound();
    }

    // POST api/orphanages/{id}
    [HttpPost]
    public ActionResult <OrphanageReadDto> CreateOrphanage(OrphanageCreateDto orphanageCreateDto)
    {
      var orphanage = _mapper.Map<Orphanage>(orphanageCreateDto);
      _repository.CreateOrphanage(orphanage);
      _repository.SaveChanges();

      return Ok(orphanage);
    }
  }
}