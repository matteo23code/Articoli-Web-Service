using Microsoft.AspNetCore.Mvc;

namespace ArticoliWebService.Controller
{
    [ApiController] //le notazioni all' interno dell .net core vengono identificate dentro alle parentesi quadre;
    [Route("api/saluti")]
    public class SalutiController
    {
        public string getSaluti()
        {
            return "Saluti, sono la tua web api creta con C# ";
        }
    }
}