using System;
using System.ComponentModel.DataAnnotations;

namespace FacturasOnline.Core.Models
{
    public class Users
    {
        public int Id {get;set;}
        [Required]
        public string userName {get;set;}
        public string FullName {get;set;}
        public DateTime LastLogin {get;set;}
    }
}