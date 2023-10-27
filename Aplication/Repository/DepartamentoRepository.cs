using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Aplication.Repository
{
    public class DepartamentoRepository : GenericRepositoryString<Departamento>, IDepartamento
    {
        private readonly AutenticacionContext _context;

        public DepartamentoRepository(AutenticacionContext context) : base(context)
        {
            _context = context;
        }
    }
}