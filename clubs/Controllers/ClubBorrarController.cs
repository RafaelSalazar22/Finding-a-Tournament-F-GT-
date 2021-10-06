using Microsoft.AspNetCore.Mvc;
using clubs.Entities;

namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubBorrarController : ControllerBase
    {
        [HttpPost]
        public string BorrarClubs(Clubs club)
        {
            string Nombre_Club = club.Nombre_club;
            string mensaje;

            if(Nombre_Club !="")
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