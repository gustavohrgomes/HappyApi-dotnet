using System.Collections.Generic;

namespace Happy.Dtos
{
  public class OrphanageReadDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    
    public double Latitude { get; set; }

    public double Longitude { get; set; }
    
    public string About { get; set; }
   
    public string Instructions { get; set; }
    
    public string Opening_hours { get; set; }

    public bool Open_on_weekends { get; set; }

    public IEnumerable<ImageFileDto> Images { get; set; }
  }
}