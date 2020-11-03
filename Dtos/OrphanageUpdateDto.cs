using System.ComponentModel.DataAnnotations;

namespace Happy.Dtos
{
  public class OrphanageUpdateDto
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public double Latitude { get; set; }

    [Required]
    public double Longitude { get; set; }

    [Required]
    public string About { get; set; }

    [Required]
    [MaxLength(300)]
    public string Instructions { get; set; }

    [Required]
    public string Opening_hours { get; set; }

    [Required]
    public bool Open_on_weekends { get; set; }
  }
}