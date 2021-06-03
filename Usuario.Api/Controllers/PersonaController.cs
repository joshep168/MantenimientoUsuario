using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Usuario.Domain.Entities;
using Usuario.Domain.Interfaces.Services;

namespace Usuario.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaSevice;

        public PersonaController(IPersonaService personaService) {
            _personaSevice = personaService;
        }

        [HttpGet]
        public IEnumerable<Persona> ListarUsuarios() {
            return _personaSevice.RetonarListadoDePersona();
        }

        [HttpGet("{id}")]
        public Persona Usuarios(string id)
        {
            return _personaSevice.RetonarPersona(id);
        }


    }
}
