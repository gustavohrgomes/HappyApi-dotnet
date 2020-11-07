using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Happy.Models
{
    public class FileModel
    {
        public string Id { get; set; }
        public string Path { get; set; }
        public IEnumerable<IFormFile> Image { get; set; }
        public int OrphanageId { get; set; }
    }
}