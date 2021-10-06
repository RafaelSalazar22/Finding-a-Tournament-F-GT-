using Microsoft.AspNetCore.Mvc;
using clubs.Entities;
namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrarInformacionController : ControllerBase
    {
         [HttpPost]
        public string InformacionTorneo(InformacionTorneo info)
        {
            string Discipplina =info.Diciplina;

            string mensaje;

            if(Discipplina !="")
            {
                mensaje="Se elimino con exito la informacion del torneo";
            }
            else 
            {
                mensaje="No se pudo elimar el torneo intente de nuevo";
            }
            return mensaje;
        }
    }
}