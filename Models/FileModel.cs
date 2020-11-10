using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Happy.Models
{
    public class FileModel
    {
        
        public int Id { get; set; }
        public string Path { get; set; }
        public Orphanage Orphanage { get; set; }
        public int OrphanageId { get; set; }
    }
}