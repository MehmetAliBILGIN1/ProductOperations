using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductOperations.Models
{   
    [Table("Companys")]
    public class Company
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public double Price { get; set; }
        public int Result { get; set; }
        
    }
}