using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Happy.Dtos
{
  public class ImageFileDto
  {
    public string Id { get; set; }
    public string Path { get; set; }
    public int OrphanageId { get; set; }
  }
}