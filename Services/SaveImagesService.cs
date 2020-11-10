using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Happy.Models;
using Happy.Database;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Happy.Services
{
  public class SaveImagesService
  {
    private readonly IWebHostEnvironment _hostEnvironment;
    private readonly HappyDbContext _context;
    private readonly IMapper _mapper;

    public SaveImagesService(IWebHostEnvironment hostEnvironment, HappyDbContext context, IMapper mapper)
    {
      _hostEnvironment = hostEnvironment;
      _context = context;
      _mapper = mapper;
    }

    public void SaveImage(IFormFileCollection imagesFromForm, Orphanage orphanage)
    {
      foreach (var img in imagesFromForm) 
      {
        string imageName = new string(Path.GetFileNameWithoutExtension(img.FileName)).Replace(' ', '-');
        imageName = $"{DateTime.Now.GetHashCode()}-{imageName}{Path.GetExtension(img.FileName)}";
        var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "uploads", imageName);

        using (FileStream fileStream = new FileStream(imagePath, FileMode.Create)) 
        {
          img.CopyTo(fileStream);
        }

        var imageFile = new FileModel 
        {
          Path = imageName,
          OrphanageId = orphanage.Id
        };

        _context.Images.Add(imageFile);
      }

      _context.SaveChanges();
    }

    public bool CheckIfDirectoryExists() 
    {
      if(!Directory.Exists(_hostEnvironment.WebRootPath + "uploads"))
      {
        Directory.CreateDirectory(_hostEnvironment.WebRootPath + "uploads");
      }

      return true;
    }
  }
}