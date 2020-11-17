using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using Happy.Models;
using Happy.Database;
using Happy.Dtos;
using AutoMapper;
using System.IO;
using System;
using Microsoft.AspNetCore.Http;
using Happy.Services;
using System.Threading.Tasks;

namespace Happy.Controllers
{
  [Route("orphanages")]
  [ApiController]
  public class OrphanagesController : ControllerBase
  {
    private readonly IOrphanageRepository _orphanageRepository;
    private readonly IMapper _mapper;
    private readonly ImagesService _imagesService;

    public OrphanagesController(IOrphanageRepository orphanageRepository, IMapper mapper, ImagesService imagesService)
    { 
      _orphanageRepository = orphanageRepository;
      _mapper = mapper;
      _imagesService = imagesService;
    }

    // GET api/orphanages
    [HttpGet]
    public ActionResult <IEnumerable<OrphanageReadDto>> GetAllOrphanages()
    {
      var orphanageItems = _orphanageRepository.GetAllOrphanages();

      return Ok(_mapper.Map<IEnumerable<OrphanageReadDto>>(orphanageItems));
    }

    // GET api/orphanages/{id}
    [HttpGet("{id}", Name="GetOrphanageById")]
    public ActionResult <OrphanageReadDto> GetOrphanageById(int id)
    {
      var orphanageModel = _orphanageRepository.GetOrphanageById(id);

      if (orphanageModel == null)
        return NotFound();

      var orphanageReadDto = _mapper.Map<OrphanageReadDto>(orphanageModel);

      return Ok(orphanageReadDto);
    }

    // POST api/orphanages
    [HttpPost]
    public ActionResult <OrphanageReadDto> CreateOrphanage([FromForm] OrphanageCreateDto orphanageCreateDto)
    {
      var orphanageModel = _mapper.Map<Orphanage>(orphanageCreateDto);

      _orphanageRepository.CreateOrphanage(orphanageModel);
      _orphanageRepository.SaveChanges();

      var imagesFromForm = orphanageCreateDto.Images;
      
      _imagesService.CheckIfDirectoryExists();
      _imagesService.SaveImage(imagesFromForm, orphanageModel);

      var orphanageReadDto = _mapper.Map<OrphanageReadDto>(orphanageModel);

      return CreatedAtRoute(nameof(GetOrphanageById), new { Id = orphanageReadDto.Id }, orphanageReadDto);
    }
 
    // PUT api/orphanages/{id}
    [HttpPut("{id}")]
    public ActionResult UpdateOrphanage(int id, OrphanageUpdateDto orphanageUpdateDto)
    {
      var orphanageModelFromRepo = _orphanageRepository.GetOrphanageById(id);

      if (orphanageModelFromRepo == null)
        return NotFound();

      _mapper.Map(orphanageUpdateDto, orphanageModelFromRepo);

      _orphanageRepository.UpdateOrphanage(orphanageModelFromRepo);
      _orphanageRepository.SaveChanges();

      return NoContent();
    }

    // PATCH api/orphanages/{id}
    [HttpPatch("{id}")]
    public ActionResult PartialOrphanageUpdate(int id, JsonPatchDocument<OrphanageUpdateDto> patchOrphanage) 
    {
      var orphanageFromRepo = _orphanageRepository.GetOrphanageById(id);

      if (orphanageFromRepo == null)
        return NotFound();

      var orphanageToPatch = _mapper.Map<OrphanageUpdateDto>(orphanageFromRepo);

      patchOrphanage.ApplyTo(orphanageToPatch, ModelState);
      
      if (!TryValidateModel(orphanageToPatch))
        return ValidationProblem(ModelState);

      _mapper.Map(orphanageToPatch, orphanageFromRepo);

      _orphanageRepository.UpdateOrphanage(orphanageFromRepo);
      _orphanageRepository.SaveChanges();

      return NoContent();
    }

    // DELETE api/orphanages/{id}
    [HttpDelete("{id}")]
    public ActionResult DeleteOrphanage(int id) 
    {
      var orphanageFromRepo = _orphanageRepository.GetOrphanageById(id);

      if (orphanageFromRepo == null) 
       return NotFound();

      _orphanageRepository.DeleteOrphanage(orphanageFromRepo);
      _orphanageRepository.SaveChanges();

      return NoContent();
    }
  }
}