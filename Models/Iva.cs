using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArticoliWebService.Models
{
    public class Iva
    {
        [Key]
        public string IdIva { get; set; }
        public string Descrizione { get; set; }

        [Required]
        public Int16 Aliquota { get; set; }

        public virtual ICollection<Articoli> Articoli { get; set; } // Questa funzione crea una relazione 1 a molti con tra la prorprietà iva e Articoli
    }
}