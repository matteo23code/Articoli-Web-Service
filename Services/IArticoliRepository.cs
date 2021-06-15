using System.Collections.Generic;
using ArticoliWebService.Models;

namespace ArticoliWebService.Services
{
    public interface IArticoliRepository
    {
        ICollection<Articoli> SelArticoliByDescrizione(string Descrizione);//ci permettera di selezionare gli articoli sulla base della descrizione che fanno parte di essa

        Articoli SelArticoloByCodice(string Code);// ci permettera di selzionare un determinato articolo sulla base del suo codice interno 

        Articoli SelArticoloByEan(string Ean);// ci permerttera di selzionare un determinato articolo in base al suo codice a barre

        bool InsArticoli(Articoli articolo);// inserisce

        bool UpdArticoli(Articoli articolo);//Modificare

        bool DelArticolo(Articoli articolo);//Elimina

        bool Salva();

        bool ArticoloExists(string Code);// ci permettere di verificare l esistenza di un articolo all interno della nostra tabella
        

    }
}