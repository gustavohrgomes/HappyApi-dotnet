using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Happy.Dtos
{
  public class OrphanageCreateDto
  {
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }

    [Required]
    public string Latitude { get; set; }

    [Required]
    public string Longitude { get; set; }

    [Required]
    public string About { get; set; }

    [Required]
    [MaxLength(300)]
    public string Instructions { get; set; }

    [Required]
    public string Opening_hours { get; set; }

    [Required]
    public bool Open_on_weekends { get; set; }

    [Required]
    public IFormFileCollection Images { get; set; }
  }
}