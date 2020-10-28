using AutoMapper;
using Happy.Dtos;
using Happy.Models;

namespace Happy.Profiles
{
  public class OrphanagesProfile : Profile
  {
    public OrphanagesProfile()
    {
      CreateMap<Orphanage, OrphanageReadDto>();

      CreateMap<OrphanageCreateDto, Orphanage>();
    }
  }
}