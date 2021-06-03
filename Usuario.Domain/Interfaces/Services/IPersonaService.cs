using System.Collections.Generic;
using Usuario.Domain.Entities;

namespace Usuario.Domain.Interfaces.Services
{
    public interface IPersonaService
    {
        IEnumerable<Persona> RetonarListadoDePersona();
        
        Persona RetonarPersona(string id);
    }
}
