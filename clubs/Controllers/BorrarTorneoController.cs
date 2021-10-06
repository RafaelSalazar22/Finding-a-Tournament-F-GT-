using Microsoft.AspNetCore.Mvc;
using clubs.Entities;
namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrarTorneoController : ControllerBase
    {
         [HttpPost]
        public string BorrarTorneo(Torneo torneo)
        {
            string Nombre =torneo.Nombre_Torneo;
            string mensaje;

            if(Nombre !="")
            {
                mensaje="Se elimino con exito el Torneo";
            }
            else 
            {
                mensaje="No se pudo elimar el torneo intente de nuevo";
            }
            return mensaje;
        }
    }
}