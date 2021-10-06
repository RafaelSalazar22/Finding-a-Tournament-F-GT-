using Microsoft.AspNetCore.Mvc;
using clubs.Entities;
namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubsConsultaController : ControllerBase
    {
        [HttpPost]
        public string ConsultaSubscripcion(Persona persona)
        {
            bool Subscripcion =  persona.subscripcion;
            string mensaje;
            if(Subscripcion==true)
            {
                mensaje= "Cuenta con una suscripcion";
            }
            else
            {
                mensaje= "No tiene una subscripcion";
            }
            return mensaje;
        }
    }
}
