using Microsoft.AspNetCore.Mvc;
using clubs.Entities;
namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResultadoController : ControllerBase
    {
         [HttpPost]
        public string Resultados(Persona persona)
        {
            InformacionTorneo info= new InformacionTorneo();
            string Resultado="Esto es una simulacion de como devolveria el resultado";
            bool Subscripcion =persona.subscripcion;
            info.Resultados_Torneo=Resultado;
            string Mensaje;
            if(Subscripcion==true)
            {
                Mensaje="Cuenta con una subscripcion Puede ver los resultados";
                return  Mensaje+"\n"+Resultado;  
            }
            else
            {
                return Mensaje="No cuenta con una subscripcion no puede ver los Resultados";
            }
        }
    }
}