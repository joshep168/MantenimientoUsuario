using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Usuario.Domain.Entities
{
    public partial class Persona
    {
        public string IdPersona { get; set; }
        public string NamePersona { get; set; }
        public string DireccionPersona { get; set; }
        public int Edad { get; set; }
    }
}
