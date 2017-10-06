using System.ComponentModel.DataAnnotations;

namespace FacturasOnline.Core.Models
{
    public class UsersAccountants
    {
        public int Id {get;set;}

        [Required]
        [StringLength(255)]
        public string UserName{get;set;}
        [Required]
        [StringLength(255)]
        public string UserAccountant {get;set;}
    }
}