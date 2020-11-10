using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Happy.Models
{
    public class FileModel
    {
        public string Id { get; set; }
        public string Path { get; set; }

        [NotMapped]
        public IEnumerable<IFormFile> Images { get; set; }
        public int OrphanageId { get; set; }
    }
}