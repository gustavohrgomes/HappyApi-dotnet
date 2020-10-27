namespace Happy.Models
{
  public class Orphanage
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitutde { get; set; }
    public string About { get; set; }
    public string Instructions { get; set; }
    public string Opening_hours { get; set; }
    public bool Open_on_weekends { get; set; }
  }
}