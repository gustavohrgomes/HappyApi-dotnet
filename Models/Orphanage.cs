using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Happy.Models
{
  public class Orphanage
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public double Latitude { get; set; }

    [Required]
    public double Longitude { get; set; }

    [Required]
    [MaxLength(300)]
    public string About { get; set; }

    [Required]
    public string Instructions { get; set; }

    [Required]
    public string Opening_hours { get; set; }

    [Required]
    public Boolean Open_on_weekends { get; set; }

    public IEnumerable<FileModel> Images { get; set; }
  }
}