using AutoMapper;
using Happy.Dtos;
using Happy.Models;

namespace Happy.Profiles
{
  public class ImagesProfile : Profile
  {
    public ImagesProfile()
    {
        CreateMap<FileModel, ImageFileDto>();
        CreateMap<ImageFileDto, FileModel>();
    }
  }
}