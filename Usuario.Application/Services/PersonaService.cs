using System.Collections.Generic;
using Usuario.Domain.Entities;
using Usuario.Domain.Interfaces.Repositories;
using Usuario.Domain.Interfaces.Services;

namespace Usuario.Application.Services
{
    public class PersonaService: IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaService(IPersonaRepository personaRepository) {
            _personaRepository = personaRepository;
        }

        public IEnumerable<Persona> RetonarListadoDePersona()
        {
            return _personaRepository.GetPersonas(); 
        }

        /// <summary>
        /// Este el metodo que retona un Usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Persona RetonarPersona(string id)
        {
            return _personaRepository.GetPersonaxId(id);
        }
    }
}
