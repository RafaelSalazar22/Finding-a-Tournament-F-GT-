using Microsoft.AspNetCore.Mvc;
using clubs.Entities;
namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgregarPersonaController : ControllerBase
    {
        [HttpPost]
        public string AgregaPersona(Persona Per)
        {
            string Nombre= Per.Nombre;
            string Apellido_Materno= Per.Apellido_Materno;
            string Apellido_Paterno =Per.Apellido_Paterno;
            string Email =Per.Email;
            string Telefono= Per.Telefono;
            bool Subscripcion =Per.subscripcion;
             string Mensaje;

            if(Nombre!="" && Apellido_Materno!="" && Apellido_Paterno!="" && Telefono!=""
             && Email!="" && Subscripcion==true || Subscripcion==false)
            {   
                 Mensaje ="la persona se ha agregado exitosamente";
                
                
            }
            else
            {
                Mensaje ="No se pudo agregar a la persona";
               
            }
            return Mensaje;
        }
    }
}