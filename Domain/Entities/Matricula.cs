using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Matricula : BaseEntity
    {
        public string IdPersonaFk { get; set; }
        public Persona Personas { get; set; }
        public int IdSalonFk { get; set; }
        public Salon Salones { get; set; }
    }
}