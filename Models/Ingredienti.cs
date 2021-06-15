using System.ComponentModel.DataAnnotations;

namespace ArticoliWebService.Models
{
    public class Ingredienti
    {
        [Key]
        public string CodArt { get; set; }
        public string Info { get; set; }

        public virtual Articoli Articolo { get; set; } // Questa funzione crea una relazione 1 a 1 tra la prorprietà  Articoli e iIngredienti
    }
}