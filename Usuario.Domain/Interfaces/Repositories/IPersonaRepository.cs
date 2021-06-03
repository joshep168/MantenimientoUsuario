using System.Collections.Generic;
using Usuario.Domain.Entities;

namespace Usuario.Domain.Interfaces.Repositories
{
    public interface IPersonaRepository
    {
        /// <summary>
        /// Este contrato se encargará de poder Listar la entidad Persona
        /// </summary>
        /// <returns>Lista de Personas</returns>
        IEnumerable<Persona> GetPersonas();

        /// <summary>
        /// Este contrato se encargará de poder buscar y retornar una Persona por ID (key)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Persona GetPersonaxId(string id);

    }
}
