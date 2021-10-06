using Microsoft.AspNetCore.Mvc;
using servicios.Entities;
using clubs.Entities;

namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiciosClubsController : ControllerBase
    {
        [HttpPost]
        public string AgregarServicio (Servicios_Clubs serv)
        {
            string Disciplina=serv.Disciplina;
            string Horario=serv.Horario;
            string Cantidad_P=serv.Cantidad_P;
            string Personas_Dis =serv.Personas_Dis;
            string Resultados= serv.Resultados; 
            string Mensaje;
     
     
            if(Disciplina!="" && Horario!="" && Cantidad_P!=""&& Personas_Dis!=""
             && Resultados!="")
            {   
                 Mensaje ="El registro de su Servicio Fue Registrado con Exitoso";
                
            }
            else
            {
                Mensaje ="El registro de su Servicio No Fue Registrado";
               
            }
            return Mensaje;
        }
    }
}