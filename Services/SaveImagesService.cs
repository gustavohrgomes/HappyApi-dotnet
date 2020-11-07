using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Happy.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Happy.Services
{
  public class SaveImagesService
  {
    private readonly IWebHostEnvironment _hostEnvironment;
    private readonly IMapper _mapper;

    public SaveImagesService(IWebHostEnvironment hostEnvironment, IMapper mapper)
    {
      _hostEnvironment = hostEnvironment;
      _mapper = mapper;
    }

    public void SaveImageOnDisk(FileModel file)
    {
      foreach (var img in file.Image) 
      {
        string imageName = new string(Path.GetFileNameWithoutExtension(img.FileName)).Replace(' ', '-');
        imageName += DateTime.Now.ToString("yyMMssfff") + Path.GetExtension(img.FileName);
        var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "uploads", imageName);

        using (FileStream fileStream = new FileStream(imagePath, FileMode.Create)) 
        {
          img.CopyTo(fileStream);
        }
      }
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