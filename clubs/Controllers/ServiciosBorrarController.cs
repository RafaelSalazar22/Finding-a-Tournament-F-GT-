using Microsoft.AspNetCore.Mvc;
using servicios.Entities;

namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiciosBorrarController : ControllerBase
    {
         [HttpPost]
        public string BorrarServicios(Servicios_Clubs servicios_Clubs)
        {
            string Disciplina = servicios_Clubs.Disciplina;
            string mensaje;

            if(Disciplina !="")
            {
                mensaje="Se elimino con exito";
            }
            else 
            {
                mensaje="No se pudo elimar";
            }
            return mensaje;
        }
    }
}