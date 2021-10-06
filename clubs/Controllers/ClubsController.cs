using Microsoft.AspNetCore.Mvc;
using System;
using clubs.Entities;
namespace clubs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubsController : ControllerBase
    {
        [HttpPost]
            
        public string Agregaclubs(Clubs club)
        {
            string Nombre_club=club.Nombre_club;
            string logo=club.logo;
            string Direccion=club.Direccion;
            string Telefono =club.Telefono;
            string Horario= club.Horario;
            string Geubicacion =club.Geoubicacion;
            string Mensaje;

            if(Nombre_club!="" && logo!="" && Direccion!=""&& Telefono!=""
             && Horario!="" && Geubicacion!="")
            {   
                 Mensaje ="Su registro Fue Exitoso";
                
                
            }
            else
            {
                Mensaje ="No se pudo registrar";
               
            }
            return Mensaje;
        }
    }
}