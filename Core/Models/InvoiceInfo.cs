using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturasOnline.Core.Models
{
    public class InvoiceInfo
    {
        public int Id {get;set;}
        [Required]
        [StringLength(200)]
        public string InvoiceName {get;set;}
        public DateTime InvoiceDate {get;set;}

        [ForeignKey("Photo")]
        public int PhotoId {get;set;} 

    }
}