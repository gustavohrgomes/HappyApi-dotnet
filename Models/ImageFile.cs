using System.ComponentModel.DataAnnotations;

namespace Happy.Models
{
  public class ImageFile
  {
    public int Id { get; set; }
    
    [Required]
    public string Path { get; set; }

    public int OrphanageId { get; set; }
  }
}