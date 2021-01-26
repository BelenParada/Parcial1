

namespace PryUserParadaMB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public class empresarios
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Nombre Completo", MinimumLength = 5)]

        public string Name { get; set; }
        [EmailAddress]
        [StringLength(100, ErrorMessage = "ingrese su Email", MinimumLength = 5)]
        public string Email { get; set; }

        

        public string street { get; set; }

        [StringLength(100, ErrorMessage = "ingrese su telefono", MinimumLength = 5)]

        public int phone { get; set; }

        [StringLength(100, ErrorMessage = "ingrese el website", MinimumLength = 5)]
        public string website { get; set; }










    }
    public class Geo
    {
        public double lat { get; set; }

        public double ing { get; set; }
    }
   

}