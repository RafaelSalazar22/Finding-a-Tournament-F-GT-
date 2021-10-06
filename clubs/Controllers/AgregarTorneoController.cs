using Microsoft.AspNetCore.Mvc;
using clubs.Entities;
namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgregarTorneoController : ControllerBase
    {
          [HttpPost]
        public string AgregarTorneo (Torneo torneo)
        {
            string Nombre_Torneo=torneo.Nombre_Torneo;
            string Cantidad_Participantes=torneo.Cantidad_Participantes;
            string tipo_torneo=torneo.tipo_torneo;
            string cantidad_Equipos =torneo.cantidad_Equipos;
            bool Acepta_Discapacitados= torneo.Acepta_Discapacitados; 
            string Mensaje;
     
     
            if(Nombre_Torneo!="" && Cantidad_Participantes!="" && tipo_torneo!=""&& cantidad_Equipos!=""
             && Acepta_Discapacitados==true || Acepta_Discapacitados ==false)
            {   
                 Mensaje ="El registro de su torneo Fue Registrado con Exitoso";
                
            }
            else
            {
                Mensaje ="El registro de su torneo No se pudo ser Registrado";
               
            }
            return Mensaje;
        }
    }
}