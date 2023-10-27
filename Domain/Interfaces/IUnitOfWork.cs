using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ICiudad Ciudades { get; }
        IDepartamento Departamentos { get; }
        IDireccion Direcciones { get; }
        IGenero Generos { get; }
        IMatricula Matriculas { get; }
        IPais Paises { get; }
        IPersona Personas { get; }
        ISalon Salones { get; }
        ITipoPersona TipoPersonas { get; }
        Task<int> SaveAsync();
    }
}