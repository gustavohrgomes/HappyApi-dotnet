using Microsoft.AspNetCore.Http;

namespace Happy.Models
{
    public class FileModel
    {
        public string Name { get; set; }
        public IFormFile image { get; set; }
    }
}