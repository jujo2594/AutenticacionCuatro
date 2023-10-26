using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Direccion : BaseEntity
    {
        public string TipoVia { get; set; }
        public int Numero { get; set; }
        public string Letra { get; set; }
        public string SufijoCardinal { get; set; }
        public int NumeroViaSec { get; set; }
        public string LetraSec { get; set; }
        public string SufijoCardinalSec { get; set; }
        public Persona Personas { get; set; }
    }
}