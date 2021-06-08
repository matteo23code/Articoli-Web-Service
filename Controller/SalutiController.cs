
using System;
using Microsoft.AspNetCore.Mvc;

namespace ArticoliWebService.Controller
{
    [ApiController] //le notazioni all' interno dell .net core vengono identificate dentro alle parentesi quadre;
    [Route("api/saluti")]
    public class SalutiController
    {
        public string getSaluti()
        {
            return "\"Saluti, sono la tua web api creta con C# \"";
        }
        [HttpGet("{Nome}")]
        public string getSaluti2(string Nome){
            try
            {
                if (Nome == "Matteo")
                    throw new Exception("\"Errore: L'utente Matteo è disabilitato!\"");
                
                else
                    return string.Format("\"Saluti, {0} sono il tuo primo web service creato con C#\"", Nome);           
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        } 
    }
}