using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona : BaseEntityString
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdGeneroFk { get; set; }
        public Genero Generos { get; set; }
        public string IdCiudadFk { get; set; }
        public Ciudad Ciudades { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TipoPersonas { get; set; }
        public int IdDireccionFk { get; set; }
        public Direccion Direcciones { get; set; }
        public ICollection<TrainerSalon> TrainerSalones { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}