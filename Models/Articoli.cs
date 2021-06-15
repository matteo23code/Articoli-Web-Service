using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ArticoliWebService.Models
{
    
    public class Articoli
    {
        [Key] // chiave primaria
        [MinLength(5, ErrorMessage = "Il numero minimo di caratteri è 5")]
        [MaxLength(30, ErrorMessage = "Il numero massimo di caratteri è 30")] // Stiamo impostando la lunghezza min e max del CodArt
        public string CodArt { get; set; }
        [MinLength(5, ErrorMessage = "Il numero minimo di caratteri è 5")]
        [MaxLength(80, ErrorMessage = "Il numero massimo di caratteri è 80")] // Stiamo impostando la lunghezza min e max della Descrizione
        public string Descrizione { get; set; }
        public string Um { get; set; }
        public string CodStat { get; set; }

        [Range(0, 100, ErrorMessage = "I Pezzi per cartone devono essere comprersi tra 0 e 100")] // Stiamo impostando range min e max dei pezzi per cartone
        public int? PzCart { get; set; } // il punto interrogativo sostituisce il valore null con un valore vuoto
        [Range(0.01, 100, ErrorMessage = "I peso netto deve essere compreso tra 0.01 e 100")] // Stiamo impostando range min e max del peso netto
        public double? PesoNetto { get; set; }
        public Int16? idiva { get; set; }
        public int? idfamass { get; set; }
        public string idstatoart { get; set; }

        public DateTime? Datacreazione { get; set; }

        //proprietà di collegamento classi models
        public virtual ICollection<Ean> Barcode { get; set; } // uesta funzione crea una relazione 1 a molti con tra la prorprietà Articoli e Barcode

        public virtual Ingredienti Ingrediente { get; set; } // Questa funzione crea una relazione 1 a 1 tra la prorprietà Articoli e Ingredienti

        public virtual Iva iva { get; set; } // Questa funzione crea una relazione molti a 1 tra la prorprietà Articoli e Iva

        public virtual FamAssort FamAssort { get; set; } // Questa funzione crea una relazione molti a 1 tra la prorprietà Articoli e FamAssort

    }
}