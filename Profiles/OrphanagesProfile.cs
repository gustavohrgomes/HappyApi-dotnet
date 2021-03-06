using AutoMapper;
using Happy.Dtos;
using Happy.Models;

namespace Happy.Profiles
{
  public class OrphanagesProfile : Profile
  {
    public OrphanagesProfile()
    {
      // Domain to DTO
      CreateMap<Orphanage, OrphanageReadDto>();
      CreateMap<Orphanage, OrphanageCreateDto>();


      // DTO to Domain
      CreateMap<OrphanageCreateDto, Orphanage>();
      CreateMap<OrphanageReadDto, Orphanage>();
      CreateMap<OrphanageUpdateDto, Orphanage>()
        .ForMember(orphanage => orphanage.Id, option => option.Ignore());
      CreateMap<Orphanage, OrphanageUpdateDto>();
    }
  }
}