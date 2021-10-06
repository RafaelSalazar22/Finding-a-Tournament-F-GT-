using Microsoft.AspNetCore.Mvc;
using clubs.Entities;

namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrarPersonaController : ControllerBase
    {
         [HttpPost]
        public string BorrarClubs(Persona pers)
        {
            string Nombre =pers.Nombre;
            string mensaje;

            if(Nombre !="")
            {
                mensaje="Se elimino con exito a la persona";
            }
            else 
            {
                mensaje="No se pudo elimar a la personas intente de nuevo";
            }
            return mensaje;
        }
    }
}