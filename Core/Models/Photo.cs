using System.ComponentModel.DataAnnotations;

namespace FacturasOnline.Core.Models
{
    public class Photo
    {
        public int Id {get;set;}
        [Required]
        [StringLength(255)]
        public string FileName{get;set;}
        [Required]
        public string userName {get;set;}
    }
}