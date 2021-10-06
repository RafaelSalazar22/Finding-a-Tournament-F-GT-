using Microsoft.AspNetCore.Mvc;
using clubs.Entities;
namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InformacionTorneoController : ControllerBase
    {
        [HttpPost]
        public string AgregaInformacion(InformacionTorneo torneo)
        {
            string Diciplina=torneo.Diciplina;
            int Cantidad_Equipos= torneo.Cantidad_Equipos;
            int Cantidad_Personas =torneo.Cantidad_Personas;
            int Num_Rondas =torneo.Num_Rondas;
            string tipo_Torneo= torneo.Tipo_Torneo;
            string Resultados_Torneo= torneo.Resultados_Torneo;
            string Mensaje;

            if(Diciplina!="" && Cantidad_Equipos >0 && Num_Rondas>0 && tipo_Torneo!=""
             && Resultados_Torneo!="")
            {   
                 Mensaje ="La informacion del Torneo Ha Sido Agregado Exitosamente";
                
                
            }
            else
            {
                Mensaje ="La informacion del Torneo no se Pudo Agregar";
               
            }
            return Mensaje;
        }
    }
}