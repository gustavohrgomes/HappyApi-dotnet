using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Happy.Dtos
{
  public class ImageFileDto
  {
    public int Id { get; set; }

    public string Path { get; set; }

    
  }
}