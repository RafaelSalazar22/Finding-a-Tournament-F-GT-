using System;
namespace clubs.Entities
{
    public class Torneo
    {
      public string Nombre_Torneo {get; set;}
      public  string Cantidad_Participantes {get;  set;}
      public string tipo_torneo {get; set;}
      public string cantidad_Equipos {get; set;}

      public bool  Acepta_Discapacitados {get;set;}    
    }
}