using Microsoft.AspNetCore.Mvc;
using clubs.Entities;
namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogearseController : ControllerBase
    {
          [HttpPost]
        public string Logearse(Login log)
        {
            string email = log.email;
            string password = log.password;
            string mensaje;

            if(email !=""&& password !="")
            {
                mensaje="Te pudiste logear correctamente";
            }
            else 
            {
                mensaje="No se pudo logear";
            }
            return mensaje;
        }
    }
}