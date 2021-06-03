using System.Collections.Generic;
using System.Linq;
using Usuario.Domain.Entities;
using Usuario.Domain.Interfaces.Repositories;
using Usuario.Infrastructure.Data;

namespace Usuario.Infrastructure
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly USUARIOContext _context;

        public PersonaRepository(USUARIOContext context) {
            _context = context;
        }
        public IEnumerable<Persona> GetPersonas()
        {
            return _context.Persona.AsEnumerable();
        }

        public Persona GetPersonaxId(string id)
        {
            return _context.Persona.Find(id);
        }
    }
}
