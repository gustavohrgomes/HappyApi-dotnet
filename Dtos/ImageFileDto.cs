namespace Happy.Dtos
{
  public class ImageFileDto
  {
    public int Id { get; set; }

    public string Path { get; set; }

    public string Url => ( $"https://localhost:5001/uploads/{Path}" );
  }
}